using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
