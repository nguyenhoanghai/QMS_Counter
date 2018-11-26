using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GPRO_QMS_Counter
{
    public partial class FrmSoundSetting : Form
    {
        static string sSettingFolder = string.Empty;
        AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public FrmSoundSetting()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FrmSoundSetting.sSettingFolder = (this.txtPath.Text = this.folderBrowserDialog1.SelectedPath.ToString());
                LoadFolder();
            }
        }

        private void LoadFolder()
        {
            this.lvFiles.Items.Clear();
            this.lvFiles.Columns.Add("Col1", 120);
            this.lvFiles.Columns.Add("Col2", 120);
            this.lvFiles.Columns.Add("Col3", 120);
            string[] files;
            try
            {
                files = Directory.GetFiles(this.folderBrowserDialog1.SelectedPath, "*.wav");
            }
            catch
            {
                files = Directory.GetFiles(Application.StartupPath, "*.wav");
            }
            string[] array = files;
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                string fileName = Path.GetFileName(text);
                ListViewItem listViewItem = new ListViewItem(fileName);
                listViewItem.Tag = text;
                listViewItem.ImageIndex = 0;
                this.lvFiles.Items.Add(listViewItem);
            }
        }

        private void btSetDeskNumber_Click(object sender, EventArgs e)
        {
            //frmDeskNumber frmDeskNumber = new frmDeskNumber();
            //frmDeskNumber.ShowDialog();
            //lstSetOfSound.Items.Clear();
            //lstSetOfSound.Items.AddRange(FrmMain.arrNumberSoundName);		
        }

        private void btSave_Click(object sender, EventArgs e)
        {
          //  Settings.Default.soundFolder = (FrmMain.sSoundFolder = this.txtPath.Text);
          //  Settings.Default.soundString = (FrmMain.sSoundString = this.txtSound.Text);
          //  Settings.Default.Save();
            base.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPlaySound_Click(object sender, EventArgs e)
        {
            if (this.txtSound.Text != "")
            {
                IWMPPlaylist iWMPPlaylist = this.axWindowsMediaPlayer1.playlistCollection.newPlaylist("ListTemp");
                string str = this.txtPath.Text.Trim().Replace("\\", "\\\\") + "\\\\";
                string[] array = this.txtSound.Text.Split(new char[]
				{
					' '
				});
                string[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    if (text != "<@TicketSound1@>" && text != "<@TicketSound2@>" && text != "<@TicketSound3@>" && text != "<@TicketSound4@>" && text != "<@TicketSound5@>")
                    {
                        IWMPMedia pIWMPMedia = this.axWindowsMediaPlayer1.newMedia(str + text);
                        iWMPPlaylist.appendItem(pIWMPMedia);
                    }
                }
                this.axWindowsMediaPlayer1.currentPlaylist = iWMPPlaylist;
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            TextBox expr_07 = this.txtSound;
            expr_07.Text = expr_07.Text + " " + this.lvFiles.SelectedItems[0].Text;
        }

        private void FrmSoundSetting_Load(object sender, EventArgs e)
        {
            //FrmSoundSetting.sSettingFolder = (this.txtPath.Text = FrmMain.sSoundFolder);
            //this.txtSound.Text = FrmMain.sSoundString;
            //this.folderBrowserDialog1.SelectedPath = this.txtPath.Text;
            //this.lstSetOfSound.Items.Clear();
            //this.lstSetOfSound.Items.AddRange(FrmMain.arrNumberSoundName);
            //this.LoadFolder();
        }

        private void txtSound_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.txtSound.SelectionStart;
            int num = this.txtSound.Text.IndexOf(' ', selectionStart);
            int selectionStart2 = 0;
            string text = string.Empty;
            if (num != -1)
            {
                text = this.txtSound.Text.Substring(0, num);
            }
            else
            {
                text = this.txtSound.Text;
            }
            if (text.LastIndexOf(' ') != -1)
            {
                selectionStart2 = 1 + text.LastIndexOf(' ');
                text = text.Substring(1 + text.LastIndexOf(' '));
            }
            this.txtSound.SelectionStart = selectionStart2;
            this.txtSound.SelectionLength = text.Length;
        }

        private void txtSound_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar != '.');
        }

        private void btTicketSound_Click(object sender, EventArgs e)
        {
            TextBox expr_07 = this.txtSound;
            expr_07.Text += " <@TicketSound2@>";
        }

        private void lstSetOfSound_DoubleClick(object sender, EventArgs e)
        {
            TextBox expr_07 = this.txtSound;
            object text = expr_07.Text;
            expr_07.Text = string.Concat(new object[]
			{
				text,
				" <@TicketSound",
				this.lstSetOfSound.SelectedIndex + 1,
				"@>"
			});
        }
    }
}
