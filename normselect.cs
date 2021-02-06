using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectnote
{
    public partial class normselect : Form
    {

        

        public normselect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //on click stel in punt/maxpunt * 9 + 1
        {
            Form1.mode = 1;
        }

        private void button2_Click(object sender, EventArgs e) //on click stel in punt/maxpunt * 10 + 0
        {
            Form1.mode = 2;
        }

        private void button3_Click(object sender, EventArgs e) //on click stel in punt/maxpunt * 9.5 + 0.5 + max punten/20
        {
            Form1.mode = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.mode = 4;
            decimal pointdec = Convert.ToDecimal(textBox9.Text);
            Form1.point = pointdec;
        }
    }
}
