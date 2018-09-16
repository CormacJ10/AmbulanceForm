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
    public partial class AddOfficerForm : Form
    {
        public AddOfficerForm()
        {
            InitializeComponent();
            using(StaffMemberContext dc= new StaffMemberContext())
            {
                var ambulances = from k in dc.Ambulances select k;
                String[] ambulance =new String[ambulances.Count()];
                int count = 0;
                foreach(Ambulance a in ambulances)
                {
                    ambulance[count] = a.AmbulanceID;
                    count += 1;
                }
                String[] skills = { "Basic", "Intermediate", "Advanced" };
                for(int h=0; h<skills.Length; h++)
                {
                    skillComboBox.Items.Add(skills[h]);
                }
                for(int i=0; i<ambulance.Length; i++)
                {
                    ambComboBox.Items.Add(ambulance[i]);
                }
                skillComboBox.SelectedIndex = 0;
                ambComboBox.SelectedIndex = 0;
                validateFirst();
                validateSur();
                validateSkill();
                validateAmbulance();
                validateID();
            }
            fnTextBox.Focus();
        }

        public AddOfficerForm(String givenNames, String surname, String ID, String skill, String AmbulanceID)
        {
            InitializeComponent();
            int counterA = 0;// count of Skill Combo Box Index.
            int counterS = 0;//counter of Ambulance Combo Box.
            using (StaffMemberContext dc = new StaffMemberContext())
            {
                var ambulances = from k in dc.Ambulances select k;
                String[] ambulance = new String[ambulances.Count()+1];
                ambulance[0] = "None";
                int count = 1;
                foreach (Ambulance a in ambulances)
                {
                    ambulance[count] = a.AmbulanceID;
                    count += 1;
                }
                String[] skills = { "Basic", "Intermediate", "Advanced" };
                for (int h = 0; h < skills.Length; h++)
                {
                    skillComboBox.Items.Add(skills[h]);
                    if (skills[h].Equals(skill))
                    {
                        counterS = h;
                    }
                }
                for (int i = 0; i < ambulance.Length; i++)
                {
                    ambComboBox.Items.Add(ambulance[i]);
                    if (ambulance[i].Equals(AmbulanceID))
                    {
                        counterA = i;
                    }
                }
            }
            titlelbl.Text = "Ambulance Officer: " + givenNames+surname;
            fnTextBox.Text = givenNames;
            lnTexBox.Text = surname;
            idTextBox.Text = ID;
            idTextBox.ReadOnly = true;
            skillComboBox.SelectedIndex = counterS;
            ambComboBox.SelectedIndex = counterA;
            fnTextBox.Focus();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            AmbulanceOfficerForm ambulance = new AmbulanceOfficerForm();
            ambulance.Visible = true;
            Visible = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using(StaffMemberContext db= new StaffMemberContext())
            {
                String surname = lnTexBox.Text;
                String firstNames = fnTextBox.Text;
                String ID = idTextBox.Text;
                String skill = skillComboBox.SelectedItem.ToString();
                String ambID = ambComboBox.SelectedItem.ToString();
                int x;
                if (idTextBox.ReadOnly)
                {
                    var idCheck = from j in db.StaffMembers where j.ID == ID select j;
                    idCheck.First().GivenNames = firstNames.Replace(" ", "");
                    idCheck.First().Surname = surname;
                    idCheck.First().SkillLevel = skill;
                    idCheck.First().AmbulanceID = ambID;
                    db.SaveChanges();
                    AmbulanceOfficerForm ambulance = new AmbulanceOfficerForm();
                    ambulance.Visible = true;
                    Visible = false;
                }
                else
                {
                    if (!(int.TryParse(ID, out x)) || ID.Length != 6)
                    {
                        MessageBox.Show("ID must be a number.\n Or the ID length must be of length 6.");
                        idTextBox.Clear();
                        idTextBox.Focus();
                    }
                    else
                    {
                        var idCheck = from j in db.StaffMembers where j.ID == ID select j;
                        if (idCheck.Count() != 0)
                        {
                            MessageBox.Show("ID must be unique.");
                            idTextBox.Clear();
                            idTextBox.Focus();
                        }
                        else
                        {
                            var newMem = new StaffMember { GivenNames = firstNames, Surname = surname, ID = ID, SkillLevel = skill, AmbulanceID = ambID };
                            db.StaffMembers.Add(newMem);
                            db.SaveChanges();
                            AmbulanceOfficerForm ambulance = new AmbulanceOfficerForm();
                            ambulance.Visible = true;
                            Visible = false;
                        }
                    }
                }
            }
        }

        private void AddOfficerForm_Load(object sender, EventArgs e)
        {

        }

        private void AddOfficerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void validateFirst()
        {
            if (String.IsNullOrEmpty(fnTextBox.Text))
            {
                errorProvider1.SetError(fnTextBox, "You must enter a first name.");
            }
            else
            {
                errorProvider1.SetError(fnTextBox, String.Empty);
            }
        }
        private void validateSur()
        {
            if (String.IsNullOrEmpty(lnTexBox.Text))
            {
                errorProvider2.SetError(lnTexBox, "You must enter a surname.");
            }
            else
            {
                errorProvider2.SetError(lnTexBox, String.Empty);
            }
        }

        private void validateID()
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                errorProvider5.SetError(idTextBox, "You must enter an ID.");
            }
            else
            {
                errorProvider5.SetError(idTextBox, String.Empty);
            }
        }
        private void validateSkill()
        {
            if (skillComboBox.SelectedItem.ToString()=="Basic")
            {
                errorProvider3.SetError(skillComboBox, "Please select a skill level.");
            }
            else
            {
                errorProvider3.SetError(skillComboBox, String.Empty);
            }
        }
        private void validateAmbulance()
        {
            if (ambComboBox.SelectedItem.ToString()=="A7")
            {
                errorProvider4.SetError(ambComboBox, "Please select an ambulance ID.");
            }
            else
            {
                errorProvider4.SetError(ambComboBox, String.Empty);
            }
        }

        private void fnTextBox_Validating(object sender, CancelEventArgs e)
        {
        }

        private void skillComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
