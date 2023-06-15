using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meropriatia
{
    public partial class RegistrJuri : Form
    {
        public RegistrJuri()
        {
            InitializeComponent();
        }

        private void viewPass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPass_checkBox.Checked == false)
            {
                pass_textBox.UseSystemPasswordChar = true;
                weoPass_textBox.UseSystemPasswordChar = true;
            }
            else
            {
                pass_textBox.UseSystemPasswordChar = false;
                weoPass_textBox.UseSystemPasswordChar = false;
            }
        }

        private void RegistrJuri_Load(object sender, EventArgs e)
        {
            pass_textBox.UseSystemPasswordChar = true;
            weoPass_textBox.UseSystemPasswordChar = true;
            merop_label.Enabled = false;
            merop_omboBox.Enabled = false;
        }

        private void zakrep_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (zakrep_checkBox.Checked == true)
            {
                merop_label.Enabled = true;
                merop_omboBox.Enabled = true;
            }
            else
            {
                merop_label.Enabled = false;
                merop_omboBox.Enabled = false;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
