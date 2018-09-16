using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3;

namespace Assignment3
{
    public partial class RosterForm : Form
    {
        int paintSwatch = 0;
        int x = 16;
        int y = 13;
        int width = 550;
        int height = 95;
        public RosterForm()
        {
            InitializeComponent();
            using (StaffMemberContext dl = new StaffMemberContext())
            {
                var ambCount = from d in dl.Ambulances select d;
                foreach (Ambulance a in ambCount)
                {
                    String idA = a.AmbulanceID;
                    TextBox rosterBox = new TextBox();
                    rosterBox.Location = new Point(x, y);
                    rosterBox.Width = width;
                    rosterBox.Height = height;
                    rosterBox.Multiline = true;
                    rosterBox.ReadOnly = true;
                    rosterBox.ScrollBars = ScrollBars.Vertical;
                    y = y + height + 22;//Gap between two buttons.
                    using (StaffMemberContext dp = new StaffMemberContext())
                    {
                        var crewCount = from w in dp.StaffMembers where w.AmbulanceID == idA select w;
                        string[] crewList = new string[crewCount.Count()];
                        int count = 0;
                        foreach (StaffMember staff in crewCount)
                        {
                            crewList[count] = staff.ID + " (" + staff.SkillLevel + ")";
                            count++;
                        }
                        rosterBox.Text = a.AmbulanceID + Environment.NewLine + string.Join(Environment.NewLine, crewList);
                        switch (paintSwatch)
                        {
                            case 0:
                                rosterBox.BackColor = Color.Crimson;
                                paintSwatch++;
                                break;
                            case 1:
                                rosterBox.BackColor = Color.GhostWhite;
                                paintSwatch--;
                                break;
                        }
                    }
                    rosterPanel.Controls.Add(rosterBox);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            A3 returnMain = new A3();
            returnMain.Visible = true;
            Visible = false;
        }

        private void rosterPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RosterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
