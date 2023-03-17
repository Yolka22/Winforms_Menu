using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        Color backgroundcolour = new Color();

        public Form1()
        {
            InitializeComponent();

            backgroundcolour = this.BackColor;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue; 
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOliveGreen;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = backgroundcolour;
        }
    }
}
