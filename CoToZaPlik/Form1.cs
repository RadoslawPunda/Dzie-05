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

namespace CoToZaPlik
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbFileInfo.Items.Clear();
            lblFileName.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ofdFile.InitialDirectory = @"C:\tmp";
            DialogResult result = ofdFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                // wybrano plik
                lblFileName.Text = ofdFile.FileName;

                lbFileInfo.Items.Clear();
                FileInfo fileInfo = new FileInfo(ofdFile.FileName);
                lbFileInfo.Items.Add("nazwa:" + fileInfo.Name);
                lbFileInfo.Items.Add("rozmiar:" + fileInfo.Length);
                lbFileInfo.Items.Add("folder:" + fileInfo.DirectoryName);
                lbFileInfo.Items.Add("rozszerzenie:" + fileInfo.Extension);
                lbFileInfo.Items.Add("atrybuty:" + fileInfo.Attributes);
                lbFileInfo.Items.Add("data utw.:" + fileInfo.CreationTime);
                lbFileInfo.Items.Add("data dostepu:" + fileInfo.LastAccessTime);
                lbFileInfo.Items.Add("data zapisu:" + fileInfo.LastWriteTime);


            }
        }
    }
}
