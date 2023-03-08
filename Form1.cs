using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEXTBOXECOMBOBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem)) 
            {
                case 1:
                    lblMensagem.Text = "Olá "+ textBoxNome.Text + "Você nasceu em Janeiro";
                    break;

                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Fevereiro";
                    break;

                case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Março";
                    break;

                case 4:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Abril";
                    break;

                case 5:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Maio";
                    break;

                case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Junho";
                    break;

                case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Julho";
                    break;

                case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Agosto";
                    break;

                case 9:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Setembro";
                    break;

                case 10:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Outubro";
                    break;

                case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Novembro";
                    break;

                case 12:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + "Você nasceu em Dezembro";
                    break;
            }
        }

        private void cmbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
