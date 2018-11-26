 
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
    public partial class FrmViewWaitingList_N : Form
    {
        public FrmViewWaitingList_N()
        {
            InitializeComponent();
        }

        private void FrmViewWaitingList_N_Load(object sender, EventArgs e)
        {
            GetQuay();
            btView_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetQuay();
        }

        private void GetQuay()
        {
         //    cbQuay.DataSource = BLLData.Instance.GetQuay(true);
            cbQuay.DisplayMember = "TENQUAY";
        }

        private void btView_Click(object sender, EventArgs e)
        {
            BindataGridView();
        }

        private void BindataGridView()
        {
        //    var q = (QUAY)cbQuay.SelectedItem;
         //   gridControl1.DataSource = BLLData.Instance.GetViewAllWaitingList_N(q.MAQUAY);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            BindataGridView();
        }
    }
}
