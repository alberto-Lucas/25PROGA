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

namespace AppCadArquivo
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        //Função que retorna o caminho da pasta
        string GetCaminhoCadastro(string nomeCadastro)
        {
            //nomeCadastro = Nome da Pasta
            //Recuperamos o diretorio raiz do executavel
            string raizExe = 
                AppDomain.CurrentDomain.BaseDirectory;

            return
                Path.Combine(raizExe, nomeCadastro);
        }

        //Método para lista os arquivos
        void ListarArquivos(string caminho)
        {
            //Iremos recuperar todos os arquivos .txt
            //do caminho
            //Cada arquivo terá o seu diretorio
            //e onde cada diretorio será uma string
            //ou seja teremos um conjunto de strings
            //no caso sera um array de string

            //Iremos tentar carregar os arquivos
            try
            {
                //Recuperar os arquivos de um diretorio
                //ja adicionando ao array

                string[] arquivos =
                    Directory.GetFiles(caminho, "*.txt");

                //Validar se existe algum arquivos
                if(arquivos.Length == 0)
                {
                    MessageBox.Show(
                        "Nenhum cadastro encontrado.",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return; //aborta a rotina
                }

                //Se chegou até aqui
                //foi encontrado um ou mais arquivos
                //Iremos popular a listBox
                //pela listBox possuir um array de string
                //eu consigo adicionar o nosso diretamente
                lsbCadastros.Items.AddRange(arquivos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha ao carregar os cadastros." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Iremos chamar o método para listar
            //os arquivos
            //Lembrando que o tipo do
            //cadastro (nome da pasta)
            //deve possuir o mesmo do utilizado
            //na tela de cadastro
            //no momento da gravação do arquivo
            ListarArquivos(GetCaminhoCadastro("Clientes"));
        }

        private void lsbCadastros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Primeiro precisa validar
            //se realmente temos um registro selecionado
            if (lsbCadastros.SelectedItem != null)
            {
                string caminhoArquivo = 
                    lsbCadastros.SelectedItem.ToString();

                //Podemos popular o txtConteudo com o arquivo
                txtConteudo.Text =
                    CarregarArquivo(caminhoArquivo);
            }
        }

        //Função para carregar o arquivo individualmente
        string CarregarArquivo(string arquivo)
        {
            //Variavel, que recebera o
            //conteudo do arquivo
            //que sera iniciada vazia
            string conteudo = "";

            //tentar carregar o arquivo
            try
            {
                //Carregar o conteudo
                conteudo = 
                    File.ReadAllText(arquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha ao carregar o cadastro." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            //Se teve algum problema e a variavel
            //nao foi populada, retorna vazio
            //Se deu tudo certo, retorna o
            //conteudo do arquivo

            return conteudo;
        }
    }
}
