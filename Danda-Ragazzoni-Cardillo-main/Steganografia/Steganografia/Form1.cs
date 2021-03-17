using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        Form2 miaForm2 = new Form2();
        Form3 miaForm3 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string conversione(string convertire)
        {
            int i = 0;
            string convertita = "";
            while (convertire[i] == null)
            {
                //convertita += ;
            }
            return convertita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miaForm2 = new Form2();
            miaForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miaForm3 = new Form3();
            miaForm3.Show();
        }
    }
}
