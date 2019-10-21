﻿using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GPRO_QMS_Counter
{
    public partial class FrmReportEvaluate : Form
    {
        string connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        public FrmReportEvaluate( )
        {
            InitializeComponent(); 
        }

        private void FrmReportEvaluate_Load(object sender, EventArgs e)
        {
            var list = new List<ModelSelectItem>();
            list.Add(new ModelSelectItem() { Id = 0, Name = "Tất cả nhân viên" });
            list.AddRange(BLLUser.Instance.GetLookUp(connectString));
            cbUser.DataSource = list;
            cbUser.DisplayMember = "Name";
        }

        private void btView_Click(object sender, EventArgs e)
        {
            var user = (ModelSelectItem)cbUser.SelectedItem;
            if (user.Id >= 0)
            {
                gridControl1.DataSource = null;
                gridControl1.DataSource = BLLUserEvaluate.Instance.Gets(connectString, user.Id, new DateTime(dtFrom.Value.Year, dtFrom.Value.Month, dtFrom.Value.Day), dtTo.Value);
            }
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = "DanhGia_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm") + ".xls";
                string path = (Application.StartupPath + "\\Export\\" );
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                gridControl1.ExportToXls((path + FileName));
                Process.Start(path);
             //   MessageBox.Show("Tạo file báo cáo thành công tại : " + (path + FileName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo file báo cáo không thành công. ex: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            string path = (Application.StartupPath + "\\Export\\");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            Process.Start(path);
        }
    }
}
