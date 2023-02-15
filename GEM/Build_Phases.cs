using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GEM
{
    public partial class Build_Phases : Form
    {
        public Build_Phases()
        {
            InitializeComponent();
        }

        private void btn_Docu_CM_Click(object sender, EventArgs e)
        {

        }

        private void btn_Select_CM1_Click(object sender, EventArgs e)
        {
            Phase_Autofill form = new Phase_Autofill();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phase_Agitator form = new Phase_Agitator();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phase_Pump form = new Phase_Pump();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phase_New_Template form = new Phase_New_Template();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phase_New_ControlTemplate form = new Phase_New_ControlTemplate();
            form.Show();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public async void button5_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "chrome";
            process.StartInfo.Arguments = @"https://github.com/W-P-I/ISA_TR_88_00_02-/tree/main/Phase%20libraries";
            process.Start();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errorProvider1 = new ErrorProvider();
            if ((richTextBox1.Text != "") && (richTextBox2.Text != "") && (richTextBox3.Text != ""))
            {
                string strFileContent = richTextBox1.Text;
                strFileContent = strFileContent.Replace("Name1", richTextBox2.Text.ToString()); // internal logic 
                strFileContent = strFileContent.Replace("Name2", richTextBox3.Text.ToString()); // internal logic 
                SaveFileDialog save = new SaveFileDialog();
                string filename = richTextBox2.Text.ToString() + richTextBox3.Text.ToString() + ".L5X";
                save.FileName = filename;
                save.Filter = "RLL file|*.L5X";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(strFileContent);
                    writer.Dispose();
                    writer.Close();
                    errorProvider1.Clear();
                    richTextBox1.Text = null;
                    richTextBox2.Text = null;
                    richTextBox3.Text = null;
                }
            }
            else
            {
                if (richTextBox2.Text == "") { errorProvider1.SetError(richTextBox2, "Error"); }
                if (richTextBox3.Text == "") { errorProvider1.SetError(richTextBox3, "Error"); }

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


/* // HTTP request 
 using (var client = new HttpClient())
 {
     var endpoint = new Uri("https://ishet.al/tijdvoorBier?");
     var result = client.GetAsync(endpoint).Result;
     var Json = result.Content.ReadAsStringAsync().Result;
     richTextBox1.Text = Json;
 }
 */