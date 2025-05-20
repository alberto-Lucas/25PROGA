using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmSelCliente: Form
    {
        public frmSelCliente()
        {
            InitializeComponent();
        }

        
        //Função que retorna o caminho da pasta do casdatro
        string GetCaminhoCadastro(string tipoCadastro)
        {
            // Diretório raiz do executável
            string diretorioRaiz = AppDomain.CurrentDomain.BaseDirectory;

            return Path.Combine(diretorioRaiz, tipoCadastro);
        }

        //Função para listar os arquivos
        void ListarArquivos(string caminho)
        {
            //Iremos recuperar todos os arquivos .txt do caminho
            //Cada arquivo terá o seu diretorio
            //onde cada diretorio é uma string
            //teremos um conjunto de string
            //no caso um array de string
            try
            {
                string[] arquivosTxt = Directory.GetFiles(caminho, "*.txt");

                //validamos se existe algum cadastro
                if (arquivosTxt.Length == 0)
                {
                    MessageBox.Show("Nenhum cadastro encontrado.", "Informação", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Populamos a listBox como array
                lsbCadastros.Items.AddRange(arquivosTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falhar ao carregar os cadastros." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message, 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Lembrando q o tipo do cadastro deve
            //possuir o mesmo nome do tipo do cadastro
            //criado na tela de cadastro
            ListarArquivos(GetCaminhoCadastro("Cliente"));
        }

        //Função para retornar o conteudo do arquivo
        string CarregarArquivo(string arquivo)
        {
            //Variavel conteudo iniciada como vazio
            string conteudo = "";

            try
            {
                //Carrega o conteudo do arquivo
                conteudo = File.ReadAllText(arquivo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                     "Falhar ao carregar o cadastro." +
                     Environment.NewLine +
                     "Erro original: " + ex.Message,
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            //Se teve problema a variavel não foi populada
            //retorna vazio
            //se deu tudo certo a varaivel é retornada
            //com o conteudo do arquivo
            return conteudo;
        }

        private void lsbCadastros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Primeiro precisamo validar se realmente
            //temos um registro selecionado
            if (lsbCadastros.SelectedItem != null)
            {
                string caminhoArquivo = lsbCadastros.SelectedItem.ToString();
                txtConteudo.Text = CarregarArquivo(caminhoArquivo);
            }
        }
    }
}
