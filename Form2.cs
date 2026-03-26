using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void btnMakeAnOrder_Click(object sender, EventArgs e)
        {
            Form form = new Frm1();
            form.ShowDialog();
        }
    }
}
