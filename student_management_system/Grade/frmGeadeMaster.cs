using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class frmGeadeMaster : Form
    {
        Boolean is_addNew = false;

        public frmGeadeMaster()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttonEnable(true);
        }

        private void buttonEnable(bool is_true)
        {
            is_addNew = is_true;
            btnAdd.Enabled = !is_true;
            btnDelete.Enabled = !is_true;
            btnEdit.Enabled = !is_true;
            btnExit.Enabled = !is_true;
            btnRefresh.Enabled = !is_true;

            btnSave.Enabled = is_true;
            btnCancel.Enabled = is_true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            buttonEnable(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {
                //insert function
            }
            else
            {
                //Update function
            }

            buttonEnable(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttonEnable(true);
            is_addNew= false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
           
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DAL.GradeDal.delete(3);
            }
            else
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.GradeDal.GetAll();
            dgvGrade.DataSource = dt;
        }

        private void frmGeadeMaster_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
