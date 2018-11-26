﻿using QMS_System.Data.BLL;
using QMS_System.Data.Model;
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
    public partial class FrmChange : Form
    {
        int number = 0;
        public FrmChange(int _number)
        {
            InitializeComponent();
            number = _number;
        }

        private void FrmChange_Load(object sender, EventArgs e)
        {
            GetMajor();
        }

        private void GetMajor()
        {
            cbQuay.Properties.DataSource = null;
            cbQuay.Properties.DataSource = BLLMajor.Instance.GetLookUp();
            cbQuay.Properties.DisplayMember = "Name";
            cbQuay.Properties.ValueMember = "Id";
            cbQuay.Properties.PopulateColumns();
            cbQuay.Properties.Columns[0].Visible = false;
            cbQuay.Properties.Columns[2].Visible = false;
            cbQuay.Properties.Columns[3].Visible = false;
            cbQuay.Properties.Columns[1].Caption = "Nghiệp vụ";
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            var obj = (ModelSelectItem)cbQuay.GetSelectedDataRow();
            if (obj != null && number != 0 && BLLDailyRequire.Instance.TranferTicket(FrmMain.loginObj.EquipCode, obj.Id, number, DateTime.Now, true))
            {
                MessageBox.Show("Chuyển phiếu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
                MessageBox.Show("Chuyển phiếu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
