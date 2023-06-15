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
    public partial class Organizator : Form
    {
        public Organizator()
        {
            InitializeComponent();
        }

        private void meropriatia_button_Click(object sender, EventArgs e)
        {
            Form InfoMeropriatia = new Meropriatia();
            InfoMeropriatia.ShowDialog();
        }

        private void myProfile_pictureBox_Click(object sender, EventArgs e)
        {
            Form Profile = new Profile();
            Profile.ShowDialog();
        }

        private void juri_button_Click(object sender, EventArgs e)
        {
            Form prosmotrinfo = new ProsmotrInfo();
            prosmotrinfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form regJuri = new RegistrJuri();
            regJuri.ShowDialog();
        }

        private void moder_button_Click(object sender, EventArgs e)
        {
            Form moderator = new Moderator();
            moderator.Show();
        }

        private void member_button_Click(object sender, EventArgs e)
        {
            Form viewMembers = new ViewMembers();
            viewMembers.Show();
        }
    }
}
