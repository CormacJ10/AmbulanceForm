using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using Assignment3;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class AmbulanceForm : Form
    {
        public AmbulanceForm()
        {
            InitializeComponent();
            try
            {
                using(StaffMemberContext db= new StaffMemberContext())
                {
                    var rowSelect = from h in db.Ambulances select h;
                    foreach(Ambulance ambulance in rowSelect)
                    {
                        ambulanceTable.Rows.Add(ambulance.AmbulanceID, ambulance.Station);
                    }
                }
            }catch(Exception e)
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

        private void AmbulanceForm_Load(object sender, EventArgs e)
        {

        }

        private void ambulanceTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ambulanceLbl_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddAmbulanceForm add = new AddAmbulanceForm();
            add.Visible = true;
            Visible = false;
        }

        private void ambulanceTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String oldID = "";
            String oldStation = "";
            int count = 0;//Counter for crew loop.
            foreach (DataGridViewRow row in ambulanceTable.SelectedRows)
            {
                oldID += row.Cells[0].Value.ToString();
                oldStation += row.Cells[1].Value.ToString();
            }
            using(StaffMemberContext dj = new StaffMemberContext())
            {
                var crewCheck = from r in dj.StaffMembers where r.AmbulanceID == oldID select r;
                String[] crewList = new String[crewCheck.Count()];
                foreach(StaffMember crew in crewCheck)
                {
                    crewList[count] = crew.GivenNames + " " + crew.Surname;
                    count++;
                }
                AddAmbulanceForm editForm = new AddAmbulanceForm(oldID, oldStation, crewList);
                editForm.Visible = true;
                Visible = false;
            }
        }

        private void AmbulanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
