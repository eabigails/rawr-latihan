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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mam mam = new mam(this);
            mam.Dock = DockStyle.Fill;
            mam.TopLevel = false;
            this.panel1.Controls.Add(mam);
            mam.Show();
        }

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drink drink = new drink(this);
            drink.Dock = DockStyle.Fill;
            drink.TopLevel = false;
            this.panel2.Controls.Add(drink);
            drink.Show();
        }

        private void snackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snack snack = new snack(this);
            snack.Dock = DockStyle.Fill;
            snack.TopLevel = false;
            this.panel3.Controls.Add(snack);
            snack.Show();
        }
    }
}
