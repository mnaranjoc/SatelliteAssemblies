using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        ResourceManager resourceManager = new ResourceManager("TestApp.string", Assembly.GetExecutingAssembly());

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeCulture(string languageCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageCode);
            lblSelectionResult.Text = resourceManager.GetString("lblResult");
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string languageCode = "";

            switch(cmbLanguage.SelectedIndex)
            {
                case 0:
                    languageCode = "en-US";
                    break;
                case 1:
                    languageCode = "he";
                    break;
                case 2:
                    languageCode = "ar-SA";
                    break;
            }

            ChangeCulture(languageCode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeCulture("en-US");
        }
    }
}
