using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Vamos chamar a tela de 
            //Cadastro de Cliente
            //Para uma tela ser exibida
            //ela precisa ser carregada 
            //ne memoria RAM

            //Primeiro vou criar a variavel
            //q sera o ponteiro
            //Crio a variavel com o mesmo tipo de
            //dado da tela, ou seja a propria tela
            //frmCadCliente é o Tipo de Dado
            //tela é a variavel q sera o ponteiro
            //Precisamos instanciar a tela
            //em memoria, usando a palavra new
            //é preciso utilizar (); para cria a tela
            frmCadCliente tela = new frmCadCliente();

            //Acessar a propriedade da tela
            //pela variavel ponteiro
            //para exibir a tela ao usuario
            //Opção Show serve pra exibir a tela

            //Show serve pra exibir a tela 
            //de maneira separada
            //tela.Show();

            //ShowDialog serve para exibir a tela
            //travando o restante o sistema
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadCliente tela =
                new frmCadCliente();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadProduto tela =
                new frmCadProduto();
            tela.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text =
                DateTime.Now.ToLongTimeString();
            lblData.Text =
                DateTime.Now.ToLongDateString();
        }
    }
}
