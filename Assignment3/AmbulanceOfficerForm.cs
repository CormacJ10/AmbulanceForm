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
    public partial class AmbulanceOfficerForm : Form
    {
        public AmbulanceOfficerForm()
        {
            InitializeComponent(); try
            {
                using (StaffMemberContext db = new StaffMemberContext())
                {
                    var rowSelect = from h in db.StaffMembers select h;
                    String ambulanceID = "";
                    foreach (StaffMember officer in rowSelect)
                    {
                        if (officer.AmbulanceID == null)
                        {
                            ambulanceID = "None";
                        }
                        else
                        {
                            ambulanceID = officer.AmbulanceID;
                        }
                        amboffcrtable.Rows.Add(officer.ID, officer.GivenNames+" "+officer.Surname, officer.SkillLevel, ambulanceID);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Environment.Exit(0);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            A3 mainForm = new A3();
            mainForm.Visible = true;
            Visible = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddOfficerForm addForm = new AddOfficerForm();
            addForm.Visible = true;
            Visible = false;
        }

        private void amboffcrtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AmbulanceOfficerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void amboffcrtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void amboffcrtable_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void amboffcrtable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String oldName;
            String oldSN = "";
            String oldID = "";
            String oldSkill = "";
            String oldAID = "";
            String oldFN = "";
            foreach (DataGridViewRow row in amboffcrtable.SelectedRows)
            {
                oldID += row.Cells[0].Value.ToString();
                oldName = row.Cells[1].Value.ToString();
                oldSkill += row.Cells[2].Value.ToString();
                oldAID += row.Cells[3].Value.ToString();
                String[] name = oldName.Split();
                for (int x = 0; x < name.Length - 1; x++)
                {
                    oldFN += name[x] + " ";
                }
                oldSN += name[name.Length - 1];
            }
            AddOfficerForm addForm = new AddOfficerForm(oldFN, oldSN, oldID, oldSkill, oldAID);
            addForm.Visible = true;
            Visible = false;
        }
    }
}
