using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace archivos3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombre = openFileDialog1.FileName;
                FileStream fS = new FileStream(nombre, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fS);
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        linea.Split(',');
                        listBox1.Items.Add(linea);
                    }

                }
                catch(FormatException ex)
                {
                    throw new MiExcepcion("frase invalida" ,ex);
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                sr.Close();
                fS.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombre = saveFileDialog1.FileName;
                FileStream archivo = new FileStream(nombre, FileMode.Create, FileAccess.Write);
                StreamWriter sW = new StreamWriter(archivo);

                try
                {
                    sW.WriteLine(" " + tBtexto.Text);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                sW.Close();
                archivo.Close();
            }
        }
    }
}
