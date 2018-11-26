using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}", this.AssemblyTitle);
            this.labelProductName.Text = this.AssemblyProduct;
            this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
            this.labelCopyright.Text = this.AssemblyCopyright;
            this.labelCompanyName.Text = this.AssemblyCompany;
            this.textBoxDescription.Text = this.AssemblyDescription;
        }

        public string AssemblyTitle
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                string result;
                if (customAttributes.Length > 0)
                {
                    AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
                    if (assemblyTitleAttribute.Title != "")
                    {
                        result = assemblyTitleAttribute.Title;
                        return result;
                    }
                }
                result = Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
                return result;
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public string AssemblyDescription
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                string result;
                if (customAttributes.Length == 0)
                {
                    result = "";
                }
                else
                {
                    result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
                }
                return result;
            }
        }
        public string AssemblyProduct
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                string result;
                if (customAttributes.Length == 0)
                {
                    result = "";
                }
                else
                {
                    result = ((AssemblyProductAttribute)customAttributes[0]).Product;
                }
                return result;
            }
        }
        public string AssemblyCopyright
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                string result;
                if (customAttributes.Length == 0)
                {
                    result = "";
                }
                else
                {
                    result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
                }
                return result;
            }
        }
        public string AssemblyCompany
        {
            get
            {
                object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                string result;
                if (customAttributes.Length == 0)
                {
                    result = "";
                }
                else
                {
                    result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
                }
                return result;
            }
        }
		
    }
}
