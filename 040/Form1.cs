using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kelimeler = { "adana", "yusuf", "bilgisayar", "nodejs", "ingilizce" }; 
        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (textBox1.Text == "Kelime Tahmin Et")
                textBox1.Text = "";
        }
        public static bool GetRandomBoolean()
        {
            return new Random().Next(100) % 2 == 0;
        }
        Random random;
        int randomint;
        string kelime;
        char[] kelimeharfleri;
        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
             randomint = random.Next(kelimeler.Length);
             kelime = kelimeler[randomint];
             kelimeharfleri = kelime.ToCharArray();

            /*var myrandom = new Random();
            int myrandomint = myrandom.Next(kelimeler.Length);
            char[] randomstring = kelimeler[myrandomint].ToCharArray();

            Label[] labels= new Label[kelimeler[myrandomint].Length];

            for (int i = 0; i < labels.Length; i++)

            {
                var randomchar = myrandom.Next(randomstring.Length);

                
                labels[i] = new Label();
                MessageBox.Show(GetRandomBoolean().ToString());
                if (GetRandomBoolean()) {
                    labels[i].Text = randomstring[randomchar].ToString();
                }
                else {
                    labels[i].Text = "----";

                }
                
                labels[i].Size = new Size(40, 40);
                labels[i].Location = new Point(i * 60, 80);
                Font ornek = label1.Font;

                labels[i].Font = ornek;
                
                labels[i].Name = "huu"+i.ToString();
                this.Controls.Add(labels[i]);
                
                 
               
            }*/

            //MessageBox.Show(kelime);
            Label[] labels = new Label[kelime.Length];
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                MessageBox.Show(GetRandomBoolean().ToString());
                if (GetRandomBoolean())
                {
                    labels[i].Text = kelimeharfleri[i].ToString();
                }
                else
                {
                    labels[i].Text = "----";

                }

                labels[i].Size = new Size(40, 40);
                labels[i].Location = new Point(i * 60, 80);
                Font ornek = label1.Font;

                labels[i].Font = ornek;

                labels[i].Name = "huu" + i.ToString();
                this.Controls.Add(labels[i]);
            }
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int adamdurum; 
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower() != kelime)
            {
                adamdurum += 1;

                if (adamdurum >5)
                {
                    MessageBox.Show("kaybettiniz");
                }
                else
                {

                    groupBox1.Controls[adamdurum].Visible = true;
                }
            }
            else
            {
                MessageBox.Show("kazandınız");
            }
        }
    }
}
