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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void regMembers_button_Click(object sender, EventArgs e)
        {
            Form addMemvers = new AddMembers();
            addMemvers.ShowDialog();
        }
    }
}
