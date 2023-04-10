using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltihan
{
    public partial class snack : Form
    {
        Form1 frml;
        public snack(Form1 _frml)
        {
            InitializeComponent();
           frml = _frml;
        }

        private void pisgor_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(pisgor.Text.ToString());
            }
        }

        private void piscok_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(piscok.Text.ToString());
            }
        }
    }
}
