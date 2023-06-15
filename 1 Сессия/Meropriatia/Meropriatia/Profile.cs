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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pass_textBox.UseSystemPasswordChar = true;
            weoPass_textBox.UseSystemPasswordChar = true;
            password_label.Enabled = false;
            twoPassword_label.Enabled = false;
            viewPass_checkBox.Enabled = false;
            pass_textBox.Enabled = false;
            weoPass_textBox.Enabled = false;
            weoPass_textBox.Enabled = false;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void swapPass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (swapPass_checkBox.Checked == true)
            {
                password_label.Enabled = true;
                twoPassword_label.Enabled = true;
                viewPass_checkBox.Enabled = true;
                pass_textBox.Enabled = true;
                weoPass_textBox.Enabled = true;
            }
            else
            {
                password_label.Enabled = false;
                twoPassword_label.Enabled = false;
                viewPass_checkBox.Enabled = false;
                pass_textBox.Enabled = false;
                weoPass_textBox.Enabled = false;
            }
        }
    }
}
