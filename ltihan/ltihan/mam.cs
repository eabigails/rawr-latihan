using System;
using System.Windows.Forms;

namespace ltihan
{
    public partial class mam : Form
    {
        Form1 frml;
        public mam(Form1 _form1)
        {
            InitializeComponent();
            frml = _form1;
        }

        private void nasgor_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(nasgor.Text.ToString());
            }
    
        }

        private void migor_Click(object sender, EventArgs e)
        {
            Control[] ctrl = frml.Controls.Find("listBox1", true);
            if (ctrl.Length > 0)
            {
                var list = ctrl[0] as ListBox;
                list.Items.Add(migor.Text.ToString());
            }
        }
    }
}
