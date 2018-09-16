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
using System.Windows.Forms;

namespace Assignment3
{
    public partial class A3 : Form
    {
        public A3()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ambulancebtn_Click(object sender, EventArgs e)
        {
            AmbulanceForm ambulance = new AmbulanceForm();
            ambulance.Visible = true;
            Visible = false; 
        }

        private void officerbtn_Click(object sender, EventArgs e)
        {
            AmbulanceOfficerForm ambulance = new AmbulanceOfficerForm();
            ambulance.Visible = true;
            Visible = false;
        }

        private void rosterbtn_Click(object sender, EventArgs e)
        {
            RosterForm roster = new RosterForm();
            roster.Visible = true;
            Visible = false;
        }

        private void A3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public class StaffMemberContext : DbContext
    {
        public StaffMemberContext() : base("MySqlConnection") { }
        public DbSet<StaffMember> StaffMembers { get; set; }
        public DbSet<Ambulance> Ambulances { get; set; }
    }
    [Table("StaffMember")]
    public class StaffMember
    {
        [Required]
        public String Surname { get; set; }
        [Required]
        public String GivenNames { get; set; }
        [Key]
        [Required]
        public String ID { get; set; }
        [Required]
        public String SkillLevel { get; set; }

        public String AmbulanceID { get; set; }
    }
    [Table("Ambulance")]
    public class Ambulance
    {
        [Required]
        [Key]
        public String AmbulanceID { get; set; }
        [Required]
        public String Station { get; set; }
    }
}
