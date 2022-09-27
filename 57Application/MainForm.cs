using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.F8))
            {
                NewApplication NwApp = new NewApplication();
                NwApp.Show();
            }
            if (e.KeyCode == (Keys.F10))
            {
                ApplicationList AppList = new ApplicationList();
                AppList.Show();
            }
            if(e.KeyCode == (Keys.F6))
            {
                EditCourses Edt = new EditCourses();
                Edt.Show();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewApplication NwApp = new NewApplication();
            NwApp.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ApplicationList AppList = new ApplicationList();
            AppList.Show();
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            EditCourses Edt = new EditCourses();
            Edt.Show();
        }
    }
}
