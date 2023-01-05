using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace GEM
{
    public partial class Form2 : Form
    {

        public string Dataholder = "";                   // contains selected equipmentmodule
        public string Dataholder_File_name = "";         // contains equipmentmodule file name
        public string CM_File_name = "";                 // contains equipmentmodule file name
        public string Previous_CM_File_name = "";                 // contains equipmentmodule file name
        public int list_count = 0;

        public string CM_id = "";
        public Form2()
        {
            InitializeComponent();

        }
        private void OpenURL(string url)
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            // Get the default browser path on the system
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Dataholder_File_name;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Select_CM_Click(object sender, EventArgs e)
        {
            int start = 0;                                          // define start var      
            int end = 0;                                            // define end var
            string strFileContent = Program.G_CM_Content;
            int size = strFileContent.Length;
            string temp = strFileContent;
            start = temp.IndexOf("<Tags Use");
            end = temp.IndexOf("</Tags");
            temp=temp.Substring(start, end-start);
            //Debug.Text = temp;
            //Debug.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Debug_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Docu_CM_Click(object sender, EventArgs e)
        {
            OpenURL("https://github.com/W-P-I/samlip-spc-france-20226218-Cm-350-Hybride");
        }

        private void btn_Select_CM1_Click(object sender, EventArgs e)
        {
            CM_id = "HMI_IA_Sensor";
            ControlModule_4_20mA form = new ControlModule_4_20mA();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.G_debug = Program.G_EM_Dataholder;
            //Program.G_debug = Program.G_CM_Datalist[0];
            //Debug.Text = Program.G_debug;
            //Debug.Text = Program.G_CM_Content;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Program.G_debug=listBox1.SelectedItems[0].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CM_id = "PF525";
            ControlModule_PF525 form = new ControlModule_PF525();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Update();
            if (Program.G_CM_FileName != Previous_CM_File_name)
            {
                listBox1.Items.Insert(list_count, Program.G_CM_FileName);
                Program.G_CM_Datalist = new string[] { Program.G_CM_FileName + ":" + CM_id };
                Previous_CM_File_name = Program.G_CM_FileName;
                list_count++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            const string quote = "\"";                                                          // local mem for the " token for searching in XML file

            Program.G_debug=Program.G_EM_Dataholder.IndexOf("<Routine Use=" + quote+ "Target"+ quote+ " Name="+ quote+listBox1.SelectedItems[0].ToString()+quote).ToString();
            Config_EP form = new Config_EP();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CM_id = "DigitalSensor";
            ControlModule_DigitalSensor form = new ControlModule_DigitalSensor();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CM_id = "Valve";
            ControlModule_Valve form = new ControlModule_Valve();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Build_EM_Save form = new Build_EM_Save();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Build_EM_Save form = new Build_EM_Save();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CM_id = "Guardswitch";
            ControlModule_Guardswitch form = new ControlModule_Guardswitch();
            form.Show();

        }
    }
}
