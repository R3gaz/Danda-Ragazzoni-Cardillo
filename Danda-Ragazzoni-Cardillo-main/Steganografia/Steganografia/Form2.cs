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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)      //caricamento immagine
        {
            OpenFileDialog apri = new OpenFileDialog();     //variabile di tipo "carica file"
            apri.Filter = "File immagine(*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.png; *.bmp";     //filtro per poter inserire solo immagini
            if (apri.ShowDialog() == DialogResult.OK)       //se il caricamento del file avviene con successo
            {
                pictureBox1.Image = new Bitmap(apri.FileName);      //metto l'immagine caricata nella picturebox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Non hai caricato un'immagine!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (richTextBox1.Text.Length == 0)
                    MessageBox.Show("Non hai inserito il messaggio!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    pictureBox1.Image = steganografia(pictureBox1.Image, richTextBox1.Text);
                }
            }
        }
        private Image steganografia(Image input, string messaggio)
        {
            int x = 0, y = 0;
            int red = 0, green = 0, blue = 0;
            Bitmap output = new Bitmap(input.Width, input.Height);

            //output.SetPixel(x, y, colore);
            return output;
        }
    }
}
