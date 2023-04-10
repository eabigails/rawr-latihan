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
   
    public partial class drink : Form

    {

        Form1 frml;
        public drink(Form1 _frml)
        {
            InitializeComponent();
            frml = _frml;
        }

        private void drink_Load(object sender, EventArgs e)
        {

        }

        private void soda_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(soda.Text.ToString());
            }
        }

        private void water_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(water.Text.ToString());
            }
        }
    }
}
