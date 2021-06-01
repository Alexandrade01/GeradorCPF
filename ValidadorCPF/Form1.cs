using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = string.Empty;
            try
            {
                cpf = txtcpf.Text;
                validadores Validador = new validadores();

                // conversao de string para int 
                //int teste = Convert.ToInt32(cpf[0].ToString());
                //Console.WriteLine(teste);
                int Digito1 = Validador.Digito1(cpf);
                int Digito2 = Validador.Digito2(cpf);


                if (Validador.TamanhoDigitos(Digito1, Digito2) && cpf.Length == 9)
                {
                    txtvalidador.Clear();
                    TextBox t = txtvalidador as TextBox;
                    t.BackColor = Color.Green;
                    txtvalidador.Text = $"Seu CPF é {cpf}-{Digito1}{Digito2}";

                }
                else
                {
                    txtvalidador.Clear();
                    TextBox t = txtvalidador as TextBox;
                    t.BackColor = Color.Red;
                    txtvalidador.Text = "CPF invalido!";
                }
            }
            catch
            {
                MessageBox.Show("Formato invalido");
            }
            

            
        }
    }
}
