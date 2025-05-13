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

namespace AppManipulaArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Utilizar o folderBrowserDialog
            //Iremos apresentar a tela de seleção
            //de pastas do proprio Windows
            //E iremos apresentar o caminho 
            //selecionado no txtCaminho

            //Nesse momento apenas exibimos
            //a tela de pastas
            DialogResult result =
                folderBrowserDialog1.ShowDialog();
            //Verificar se o usuario clicou em
            //OK ou Cancelar
            //Se Cancelar: não faremos nada
            //Se OK: iremos validar o preenchimento
            //do diretorio
            if(result == DialogResult.OK &&
                !string.IsNullOrWhiteSpace(
                    folderBrowserDialog1.SelectedPath))
            {
                //Agora podemos apresentar o
                //diretorio selecionado
                txtCaminho.Text = 
                    folderBrowserDialog1.SelectedPath;
            }
        }

        //Função para validar o diretorio
        bool ValidarDiretorio(
            string diretorio, string nomeArquivo)
        {
            //Validar o preenchimento dos parametros
            if(string.IsNullOrWhiteSpace(diretorio) ||
                string.IsNullOrWhiteSpace(nomeArquivo))
            {
                MessageBox.Show(
                    "Informe o diretório e o nome do arquivo" +
                    "corretamente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                //Utilizamos um return false
                //para finalizar a função
                return false;
            }

            //Validar se o diretorio é valido
            //se ele existe
            if(!Directory.Exists(diretorio))
            {
                MessageBox.Show(
                    "O diretório informa não existe.",
                    "Atenção", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            //Se chegou aqui
            //está tudo certo com o diretorio
            return true;
        }

        //Função para retornar o
        //diretorio completo
        string GetDiretorioCompleto()
        {
            //Direotio + Nome Arquivo +
            //extensão do arquivo
            return
                Path.Combine(
                    txtCaminho.Text,
                    txtNomeArquivo.Text +
                    ".txt");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Primeiro precisamos validar o diretorio
            if(!ValidarDiretorio(
                txtCaminho.Text, txtNomeArquivo.Text))
            {
                //Não preciso aprensentar mensagem
                //para o usuario AQUI
                //pois ja foi apresentada na função
                return;
            }

            //Recuperar o diretorio completo
            string caminhoCompleto =
                GetDiretorioCompleto();

            //Utilizar o Try Catch para criação
            //do arquivo, pois caso ocorrar uma falha
            //iremos tratar a mensagem para o usuario
            //Erro comum: Permissão da pasta
            try
            {
                //Verificar se ja existe o arquivo
                //Se existir apresenta mensagem 
                //para o usuario
                //se não existir, o arquivo será criado
                if(File.Exists(caminhoCompleto))
                {
                    //Se existir, notificamos o usuario
                    MessageBox.Show(
                        "O arquivo já existe.",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                //Se chegou aqui, podemos tentar
                //criar o arquivo vazio
                File.WriteAllText(caminhoCompleto, "");

                MessageBox.Show(
                    "Arquivo criado com sucesso.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Caso ocorra uma falha, notificaremos
                //o usuario
                //Só iremos notificar se ocorrer
                //uma exceção na execução do código acima
                MessageBox.Show(
                    "Ocorreu uma falha ao criar o arquivo." + 
                    Environment.NewLine + //quebra de linha <BR>
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Validar os dados do diretorio
            if(!ValidarDiretorio(
                txtCaminho.Text, txtNomeArquivo.Text))
            {
                //O messageBox é exibido na função
                //ValidarDiretorio
                return;
            }

            //Usando try, para tratar o erro
            //se ocorrer
            try
            {
                //Gravar o conteudo do campos TEXTO
                //no arquivo
                //No método de gravação, todo o conteudo
                //do arquivo é subistituido pelo novo
                //Ou seja o arquivo será limpo, e a 
                //nova informação será gravada
                //Informar o diretorio do arquivos
                //e o conteudo
                File.WriteAllText(
                    GetDiretorioCompleto(),
                    txtTexto.Text);

                MessageBox.Show(
                    "Dados gravados com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu uma falha ao gravar os " +
                    "dados no arquivo." +
                    Environment.NewLine + 
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Seguir a mesma ideia do botão gravar
            //Validar o diretorio
            if(!ValidarDiretorio(
                txtCaminho.Text, txtNomeArquivo.Text))
            {
                return;
            }

            try
            {
                //Iremos adicionar o conteudo do campo
                //Texto ao arquivo
                //Diferente da rotina de gravação
                //aqui iremos adicionar o conteudo
                //ao que ja existe no arquivo
                //Dica: o conteudo é inserido em sequencia
                //Nescessario inserir um quebra de linha
                //para sempre que inserir um novo
                //conteudo, o mesmo seria inserido
                //na linha de baixo
                File.AppendAllText(
                    GetDiretorioCompleto(),
                    txtTexto.Text + 
                    Environment.NewLine);
                //Notificamos o usuario
                MessageBox.Show(
                    "Dados adicionados com sucesso.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu uma falha ao adicionar os" +
                    "dados no arquivo." +
                    Environment.NewLine +
                    "Erro original: "+ ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //Validar diretorio
            if(!ValidarDiretorio(
                txtCaminho.Text, txtNomeArquivo.Text))
            {
                return;
            }

            try
            {
                //Validar se o arquivo realmente
                //existe
                if(File.Exists(GetDiretorioCompleto()))
                {
                    //Caso o arquivo exista
                    //iremos carregar o conteudo do arquivo
                    //e apresentar no campo txtArquivo

                    //Iremos carregar o arquivo
                    txtArquivo.Text =
                            File.ReadAllText(
                                GetDiretorioCompleto());

                    //Notificamos o usuario
                    MessageBox.Show(
                        "Arquivo carregado com sucesso.",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "O arquivo não existe.",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu uma falha ao carregar " +
                    "o arquivo." +
                    Environment.NewLine + 
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
