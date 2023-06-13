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
    public partial class AddMeropriatie : Form
    {
        public AddMeropriatie()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desk_button_Click(object sender, EventArgs e)
        {
            Form desk = new Desk();
            desk.ShowDialog();
        }
    }
}
