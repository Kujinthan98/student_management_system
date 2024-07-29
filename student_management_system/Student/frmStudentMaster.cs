﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system.Student
{
    public partial class frmStudentMaster : Form
    {
        public frmStudentMaster()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createstudent frmCreatStudent = new createstudent();
            frmCreatStudent.ShowDialog();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to clouse ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStudentEdit frmStudentEdit = new frmStudentEdit();
            frmStudentEdit.ShowDialog();
        }
    }
}
