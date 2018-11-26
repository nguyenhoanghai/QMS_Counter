 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmViewWaitingList : Form
    {
        public static bool bHaveCommbobox = false;
        public FrmViewWaitingList()
        {
            InitializeComponent();
        }

        private void FrmViewWaitingList_Load(object sender, EventArgs e)
        {
            try
            {
             //   this.dataGridView1.DataSource = BLLData.Instance.GetViewAllWaitingList();
                if (!FrmViewWaitingList.bHaveCommbobox)
                {
                    this.dataGridView1.Columns["colWorkPass"].Visible = false;
                    base.Width = 400;
                }
                else
                {
                    this.dataGridView1.Columns["colWorkPass"].Visible = true;
                    base.Width = 600;
                }
            }
            catch (Exception)
            { 
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            string[] array = this.dataGridView1.CurrentRow.Cells["colWorkPass"].EditedFormattedValue.ToString().Split(new char[]
			{
				'.'
			});
            string str = array[0];
            string sRequiredParam = str + " " + this.dataGridView1.CurrentRow.Cells["colStaffId"].Value.ToString();
          //  BLLUser.Instance.WriteRequired(FrmMain.loginObj.iCounterId, "PASS", sRequiredParam, DateTime.Now);
            base.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        { 
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (FrmViewWaitingList.bHaveCommbobox)
            //{
            //    try
            //    {
            //        DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["colWorkPass"];
            //        dataGridViewComboBoxColumn.DataSource = null;
            //        DataTable worksOfStaff = clsDataAccess.GetWorksOfStaff((int)Convert.ToInt16(this.dataGridView1.Rows[e.RowIndex].Cells["colStaffId"].Value.ToString()));
            //        dataGridViewComboBoxColumn.DataSource = worksOfStaff;
            //        dataGridViewComboBoxColumn.ValueMember = "MANVU";
            //        dataGridViewComboBoxColumn.DisplayMember = "NGHIEPVU";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi: " + ex.Message);
            //    }
            //}
        }
    }
}
