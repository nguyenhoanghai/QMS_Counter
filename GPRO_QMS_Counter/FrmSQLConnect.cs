using GPRO.Core.Hai;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmSQLConnect : Form
    {
        string conString = "", database = "";
        public FrmSQLConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (checkValid())
                if (File.Exists(Application.StartupPath + "\\DATA.XML"))
                    UpdateXMLFile();
                else
                    CreateNewXMLFile();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
            Environment.Exit(0);
        }

        private void FrmSQLConnect_Load(object sender, EventArgs e)
        {
            string info = BaseCore.Instance.GetStringConnectInfo(Application.StartupPath + "\\DATA.XML");
            if (!string.IsNullOrEmpty(info))
            {
                var infos = info.Split(',');
                txtServerName.Text = infos[0];

                txtLogin.Text = infos[2];
                txtPass.Text = infos[3];
                chkIsAuthen.Checked = bool.Parse(infos[4]);
                chkIsAuthen_CheckedChanged(sender, e);
                database = infos[1];
                getDatabases();
            }
        }

        private void chkIsAuthen_CheckedChanged(object sender, EventArgs e)
        {

            if (chkIsAuthen.Checked)
            {
                txtLogin.Enabled = false;
                txtPass.Enabled = false;
            }
            else
            {
                txtLogin.Enabled = true;
                txtPass.Enabled = true;
            }
        }

        private void getDatabases()
        {
            if (checkValid())
            {
                try
                {
                    var conn = new SqlConnection(conString);
                    conn.Open();
                    var ds = new DataSet();
                    string query = "select name from sysdatabases";
                    var da = new SqlDataAdapter(query, conn);
                    da.Fill(ds, "databasenames");
                    this.cbDatabases.DataSource = ds.Tables["databasenames"];
                    this.cbDatabases.DisplayMember = "name";
                    if (!string.IsNullOrEmpty(database))
                    {
                        cbDatabases.Text = database;
                    }
                }
                catch
                {
                    this.cbDatabases.DataSource = null;
                }
            }

        }

        private bool checkValid()
        {
            bool isPass = false;
            // Open connection to the database 
            if (!string.IsNullOrEmpty(txtServerName.Text))
            {
                if (chkIsAuthen.Checked)
                {
                    conString = string.Concat(new string[]
                     {
                    "Server = ",
                    this.txtServerName.Text,
                    ";Trusted_Connection=true;",
                     });
                    isPass = true;
                }
                else
                {
                    conString = string.Concat(new string[]
                    {
                    "Server = ",
                    this.txtServerName.Text,
                    " ; Uid = ",
                    this.txtLogin.Text,
                    " ;Pwd= ",
                    this.txtPass.Text
                    });
                    if (!string.IsNullOrEmpty(txtLogin.Text) &&
                        !string.IsNullOrEmpty(txtPass.Text))
                    {
                        isPass = true;
                    }
                }
            }
            return isPass;
        }

        private void CreateNewXMLFile()
        {
            string filename = Application.StartupPath + "\\DATA.XML";
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement("SystemConfig");
            xmlDocument.AppendChild(xmlNode);

            XmlNode xmlNode2 = xmlDocument.CreateElement("SQLServer");
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("id");
            xmlAttribute.Value = "1";
            xmlNode2.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNode2);

            XmlNode xmlNode3 = xmlDocument.CreateElement("Server_Name");
            xmlNode3.AppendChild(xmlDocument.CreateTextNode(EncryptionHelper.Instance.Encrypt(txtServerName.Text)));
            xmlNode2.AppendChild(xmlNode3);

            XmlNode xmlNode4 = xmlDocument.CreateElement("Database");
            xmlNode4.AppendChild(xmlDocument.CreateTextNode(EncryptionHelper.Instance.Encrypt(cbDatabases.Text)));
            xmlNode2.AppendChild(xmlNode4);

            XmlNode xmlNode5 = xmlDocument.CreateElement("User");
            xmlNode5.AppendChild(xmlDocument.CreateTextNode(EncryptionHelper.Instance.Encrypt(txtLogin.Text)));
            xmlNode2.AppendChild(xmlNode5);

            XmlNode xmlNode6 = xmlDocument.CreateElement("Password");
            xmlNode6.AppendChild(xmlDocument.CreateTextNode(EncryptionHelper.Instance.Encrypt(txtPass.Text)));
            xmlNode2.AppendChild(xmlNode6);

            XmlNode xmlNode7 = xmlDocument.CreateElement("Window_Authenticate");
            xmlNode7.AppendChild(xmlDocument.CreateTextNode(chkIsAuthen.Checked.ToString()));
            xmlNode2.AppendChild(xmlNode7);


            XmlNode appConfigNode = xmlDocument.CreateElement("AppConfig");
            xmlNode.AppendChild(appConfigNode);

            XmlNode templateNode = xmlDocument.CreateElement("Template");
            templateNode.AppendChild(xmlDocument.CreateTextNode(""));
            appConfigNode.AppendChild(templateNode);

            XmlNode soLienNode = xmlDocument.CreateElement("SoLien");
            soLienNode.AppendChild(xmlDocument.CreateTextNode("1"));
            appConfigNode.AppendChild(soLienNode);

            XmlNode counterIdNode = xmlDocument.CreateElement("CounterId");
            counterIdNode.AppendChild(xmlDocument.CreateTextNode("1"));
            appConfigNode.AppendChild(counterIdNode);

            XmlNode useDisplayNode = xmlDocument.CreateElement("Display");
            useDisplayNode.AppendChild(xmlDocument.CreateTextNode("False"));
            appConfigNode.AppendChild(useDisplayNode);

            XmlNode comDisplayNode = xmlDocument.CreateElement("COMDisplay");
            comDisplayNode.AppendChild(xmlDocument.CreateTextNode("COM"));
            appConfigNode.AppendChild(comDisplayNode);

            XmlNode usePrintNode = xmlDocument.CreateElement("Print");
            usePrintNode.AppendChild(xmlDocument.CreateTextNode("False"));
            appConfigNode.AppendChild(usePrintNode);

            XmlNode comPrintNode = xmlDocument.CreateElement("COMPrint");
            comPrintNode.AppendChild(xmlDocument.CreateTextNode("COM"));
            appConfigNode.AppendChild(comPrintNode);

            XmlNode printCodeNode = xmlDocument.CreateElement("PrintCode");
            printCodeNode.AppendChild(xmlDocument.CreateTextNode("27"));
            appConfigNode.AppendChild(printCodeNode);

            XmlNode readSoundNode = xmlDocument.CreateElement("ReadSound");
            readSoundNode.AppendChild(xmlDocument.CreateTextNode("False"));
            appConfigNode.AppendChild(readSoundNode);

            XmlNode soundPathNode = xmlDocument.CreateElement("SoundPath");
            soundPathNode.AppendChild(xmlDocument.CreateTextNode(""));
            appConfigNode.AppendChild(soundPathNode);

            XmlNode slNutDichVuCapPhieuNode = xmlDocument.CreateElement("NumberOfButton");
            slNutDichVuCapPhieuNode.AppendChild(xmlDocument.CreateTextNode("3"));
            appConfigNode.AppendChild(slNutDichVuCapPhieuNode);

            xmlDocument.Save(filename);
            Application.Restart();
            Environment.Exit(0);
        }

        private void UpdateXMLFile()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Application.StartupPath + "\\DATA.XML");
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("SQLServer"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            try
                            {
                                switch (node.Name)
                                {
                                    case "Server_Name": node.InnerText = EncryptionHelper.Instance.Encrypt(txtServerName.Text); break;
                                    case "Database": node.InnerText = EncryptionHelper.Instance.Encrypt(cbDatabases.Text); break;
                                    case "User": node.InnerText = EncryptionHelper.Instance.Encrypt(txtLogin.Text); break;
                                    case "Password": node.InnerText = EncryptionHelper.Instance.Encrypt(txtPass.Text); break;
                                    case "Window_Authenticate": node.InnerText = chkIsAuthen.Checked.ToString(); break; 
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
                xmlDoc.Save(Application.StartupPath + "\\DATA.XML");
                Application.Restart(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật cấu hình bị lỗi.");
            }
        }

        private void cbDatabases_Enter(object sender, EventArgs e)
        {
            getDatabases();
        }

    }
}
