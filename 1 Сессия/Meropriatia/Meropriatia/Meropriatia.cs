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
    public partial class Meropriatia : Form
    {
        public Meropriatia()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form addmeropriatie = new AddMeropriatie();
            addmeropriatie.ShowDialog();
        }
    }
}
