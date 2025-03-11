using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetodoFuncao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "F80")
                MessageBox.Show("Vc escolheu uma Ferrari");
            else if (txtModelo.Text == "FUSCA")
                MessageBox.Show("Vc escolheu um VolksWagen");
            else if (txtModelo.Text == "CIVIC")
                MessageBox.Show("Vc escolheu um Honda");
            else if (txtModelo.Text == "RENEGADE")
                MessageBox.Show("Vc escolheu um JEEP");
            else
                MessageBox.Show("Opção não encontrada");
        }

        private void btnSWITCH_Click(object sender, EventArgs e)
        {
            //O USO do SWITCH definimos os CASE
            //q são as opções fixas
            //cada CASE precisa de um break,
            //para encerar o SWITCH

            switch(cbbModelo.SelectedIndex)
            {
                case 0: MessageBox.Show("Marca NISSAN");
                    break;
                case 1: MessageBox.Show("Marca FIAT");
                    break;
                case 2: MessageBox.Show("Marca TOYOTA");
                    break;
                case 3: MessageBox.Show("Marca CHEVROLET");
                    break;
                default: MessageBox.Show("Opção não encontrada");
                    break;
            }
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNome.Text);
            MessageBox.Show(txtNome.Text, "Informação!");
            MessageBox.Show(txtNome.Text, 
                           "Informação",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            MsgInformacao(txtNome.Text);
        }

        //Vamos um metodo para 
        //exibir um MessageBox de aviso
        //pré configurado

        //Para criar o método
        //Preciso informa o tipo e o nome
        //Void = sem retorno
        void MsgInformacao(string Texto)
        {
            MessageBox.Show(Texto,  //Conteudo a ser exibido
                "Informação!",      //Titulo da mensagem
                MessageBoxButtons.OK, //Configuração de botoes
                MessageBoxIcon.Information); //Configuração Icone
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            MsgInformacao("O Nome informado é: " + txtNome.Text);
            MessageBox.Show("O Nome informado é: " + txtNome.Text);
            MsgInformacao(MsgNome(txtNome.Text));
            MessageBox.Show(MsgNome(txtNome.Text));
        }

        //Funcao
        //Que retorna uma mensagem amigavel junto do Nome
        //string RetMsgNomeAmigavel() //Exemplo
        string MsgNome(string Nome)
        {
            //usamos o return
            //para retornar o valor do metodo
            return "O Nome informado é: " + Nome;
        }
    }
}
