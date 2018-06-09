using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace zr_mod_uninstaller
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string x1;
        private void Form1_Load(object sender, EventArgs e)
        {
            metroButton2.Enabled = false;
            metroButton3.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            metroTextBox1.Text = folderBrowserDialog1.SelectedPath;
            metroButton2.Enabled = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            x1 = metroTextBox1.Text;
            metroTextBox2.Text = x1 + @"\addons";
            metroTextBox3.Text = x1 + @"\cfg\sourcemod";
            metroTextBox4.Text = x1 + @"\materials";
            metroTextBox5.Text = x1 + @"\models";
            metroTextBox6.Text = x1 + @"\sound";
            metroButton2.Enabled = false;
            metroButton3.Enabled = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Directory.Delete(metroTextBox2.Text, true);
            Directory.Delete(metroTextBox3.Text, true);
            Directory.Delete(metroTextBox4.Text, true);
            Directory.Delete(metroTextBox5.Text, true);
            Directory.Delete(metroTextBox6.Text, true);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Process.Start("About");
        }
    }
}
