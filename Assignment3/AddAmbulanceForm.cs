using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class AddAmbulanceForm : Form
    {
        public String aIDb;
        public AddAmbulanceForm()
        {
            InitializeComponent();
            AIDTextBox.Focus();
            validateAID();
            validateStation();
        }

        public AddAmbulanceForm(String ambID, String Stasyon, String[] crew)
        {
            InitializeComponent();
            titleLabel.Text = "Ambulance: " + ambID;
            AIDTextBox.Text = ambID;
            aIDb = ambID;
            StationTextBox.Text = Stasyon;
            CrewTextBox.Text = string.Join(Environment.NewLine, crew);
            AIDTextBox.BackColor=Color.AliceBlue;//To know that cell is being edited.
        }

        private void AIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AmbulanceForm back = new AmbulanceForm();
            back.Visible = true;
            Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StaffMemberContext db = new StaffMemberContext())
            {
                String aID = AIDTextBox.Text;
                String station = StationTextBox.Text;
                string isA = aID.Substring(0, 1);
                int x;
                if(aID.Length > 4)
                {
                    MessageBox.Show("Ambulance ID must be at least length 4.");
                    AIDTextBox.Clear();
                    AIDTextBox.Focus();
                }
                if (!(isA.Equals("A")))
                {
                    MessageBox.Show("Ambulance ID must start with 'A'.");
                    AIDTextBox.Clear();
                    AIDTextBox.Focus();
                }
                else
                {
                    String intCheck = aID.Substring(1);
                    if(int.TryParse(intCheck, out x))
                    {
                        if (AIDTextBox.BackColor.Equals(Color.AliceBlue))
                        {
                            using (StaffMemberContext dp = new StaffMemberContext())
                            {
                                var amb = from s in dp.Ambulances where s.AmbulanceID == aIDb select s;
                                var updateStaff = from t in dp.StaffMembers where t.AmbulanceID == aIDb select t;
                                foreach(StaffMember s in updateStaff)
                                {
                                    s.AmbulanceID = aID;
                                }
                                String istasyon = amb.First().Station;
                                dp.Ambulances.RemoveRange(amb);
                                var updatedAmb = new Ambulance { AmbulanceID=aID, Station=istasyon};
                                dp.Ambulances.Add(updatedAmb);
                                dp.SaveChanges();
                                AmbulanceForm returnForm = new AmbulanceForm();
                                returnForm.Visible = true;
                                Visible = false;
                            }
                        }
                        else
                        {
                            var idCheck = from g in db.Ambulances where g.AmbulanceID == aID select g;
                            if (idCheck.Count() == 0)
                            {
                                var newAmb = new Ambulance { AmbulanceID = aID, Station = station };
                                db.Ambulances.Add(newAmb);
                                db.SaveChanges();
                                AmbulanceForm returnForm = new AmbulanceForm();
                                returnForm.Visible = true;
                                Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Ambulance ID must be unique.");
                                AIDTextBox.Clear();
                                AIDTextBox.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The sequence following 'A' must be an integer.");
                        AIDTextBox.Clear();
                        AIDTextBox.Focus();
                    }
                }
            }
        }

        private void validateAID()
        {
            if (String.IsNullOrEmpty(AIDTextBox.Text))
            {
                AIDError.SetError(AIDTextBox, "You must enter an ambulance ID.");
            }
            else
            {
                AIDError.SetError(AIDTextBox, String.Empty);
            }
        }

        private void validateStation()
        {
            if (String.IsNullOrEmpty(StationTextBox.Text))
            {
                StationError.SetError(StationTextBox, "You must enter a Station.");
            }
            else
            {
                StationError.SetError(StationTextBox, String.Empty);
            }
        }

        private void AddAmbulanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
