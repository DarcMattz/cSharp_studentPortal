using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            showform(new Home());
        }

        private void showform(object Form)
        {
            Form frm = Form as Form;
            frm.TopLevel = false;
            this.Container.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.IconColor = Color.FromArgb(117, 207, 136);
            HomeBtn.ForeColor = Color.FromArgb(198, 210, 216);

            SubjectsBtn.IconColor = Color.FromArgb(59, 77, 82);
            SubjectsBtn.ForeColor = Color.FromArgb(59, 77, 82);

            EnrollmentBtn.IconColor = Color.FromArgb(59, 77, 82);
            EnrollmentBtn.ForeColor = Color.FromArgb(59, 77, 82);

            showform(new Home());

        }

        private void SubjectsBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.IconColor = Color.FromArgb(59, 77, 82);
            HomeBtn.ForeColor = Color.FromArgb(59, 77, 82);

            SubjectsBtn.IconColor = Color.FromArgb(117, 207, 136);
            SubjectsBtn.ForeColor = Color.FromArgb(198, 210, 216);

            EnrollmentBtn.IconColor = Color.FromArgb(59, 77, 82);
            EnrollmentBtn.ForeColor = Color.FromArgb(59, 77, 82);

            showform(new Subject());
        }

        private void EnrollmentBtn_Click(object sender, EventArgs e)
        {
            HomeBtn.IconColor = Color.FromArgb(59, 77, 82);
            HomeBtn.ForeColor = Color.FromArgb(59, 77, 82);

            SubjectsBtn.IconColor = Color.FromArgb(59, 77, 82);
            SubjectsBtn.ForeColor = Color.FromArgb(59, 77, 82);

            EnrollmentBtn.IconColor = Color.FromArgb(117, 207, 136);
            EnrollmentBtn.ForeColor = Color.FromArgb(198, 210, 216);

            showform(new Enrollment());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.IconColor = System.Drawing.Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.IconColor = System.Drawing.Color.White;
        }

    }
}
