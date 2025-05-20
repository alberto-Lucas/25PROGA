using System;
using System.IO;
using System.Windows.Forms;

namespace AppCadArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Iremos salvar o cadastro
        //em um arquivo .txt
        //Cada cadastro será um arquivo
        //individual
        //Iremos aplicar os conceitos
        //do projeto AppManipulaArquivo

        //Função que validar o arquivo
        bool ArquivoExiste(string caminho)
        {
            //Iremos validar a existencia do aquivo
            //lembrando que o nome do arquivo séra o 
            //CPF, portanto se o arquivo ja existir
            //significa que ja possui um cadastro
            //com aquele CPF
            
            return File.Exists(caminho);
        }

        //Método para gravar o conteudo no arquivo
        void GravarArquivo(
            string caminho, string conteudo)
        {
            //Iremos para a rotina de gravação do arquivo
            //Precisamos de uma atenção no inicio
            //Caso for o primeiro cadastro a pasta
            //do cadastro não deve existir
            //para isso precisamos validar se a pasta 
            //existe, se não existir, iremos cria-la

            //OBS: Não iremos usar o Try aqui
            //pois será usado na rotina anterior

            //Extrair a pasta do parametro caminho
            //onde o arquivo será salvo
            string pasta = 
                Path.GetDirectoryName(caminho);

            //Validar a existencia da pasta
            //e cria-la se nescessario
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //Agora podemos gravar o conteudo
            //no arquivo
            File.WriteAllText(caminho, conteudo);
        }

        //Função que retorna o caminho completo
        string GetDirArquivo(
            string nomePasta, string nomeArquivo)
        {
            //O caminho será montado:
            //Diretorio RAIZ do executavel
            //Nome da Pasta: será o tipo do cadastro
            //Nome do arquivo: será o CPF do cliente
            //Ex:
            //C:/Programas/AppCadArquivo/Clientes/00000000000.txt

            //Extrair o local de instalação do exceutavel
            string raizExe =
                AppDomain.CurrentDomain.BaseDirectory;

            //Juntar e criar o caminho completo
            //do arquivo
            return
                Path.Combine(
                    raizExe, nomePasta, nomeArquivo + ".txt");
        }

        //Função que retorna o cadastro
        //em forma de conteudo para o arquivo
        string GetCadastro()
        {
            //Iremos concatenas os dados do cadastro
            //para gerar o conteudo a ser gravado
            //no arquivo

            string cadastro =
                "CPF: " + txtCPF.Text +
                Environment.NewLine +
                "NOME: " + txtNome.Text +
                Environment.NewLine +
                "DATA_NASCIMENTO: " + dtpDtNascimento.Text +
                Environment.NewLine +
                "RG: " + txtRG.Text;

            return cadastro;
        }

        //Método para salvar o cadastro
        void Salvar()
        {
            //Recuperar o caminho completo
            //Onde iremos definir o tipoCadastro: Clientes
            //e o nome do arquivo, que será o CPF
            //Iremos definir o nome da pasta
            //de acordo com o tipo do cadastro
            //nesse caso o Cadastro de Clientes
            string caminhoCompleto =
                GetDirArquivo("Clientes", txtCPF.Text);

            //Precisamo validar a existencia do arquivo
            //validando junto se ja existe um cadastro
            //com o mesmo CPF informado
            if(ArquivoExiste(caminhoCompleto))
            {
                MessageBox.Show(
                    "Já existe um cadastro com este CPF.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; //Abortar a rotina
            }

            //Agora iremos tentar gravar o cadastro
            //no arquivo
            try
            {
                //Iremos gravar o conteudo do arquivo
                GravarArquivo(caminhoCompleto, GetCadastro());

                //Notificar o usuario
                //que o cadatro deu certo

                //OBS: Iremos apresentar o diretorio apenas
                //para teste interno
                //No programa final, o usuario não deve saber
                //onde o arquivo foi salvo

                MessageBox.Show(
                    "Registro salvo com sucesso!" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Salvo em: " + caminhoCompleto,
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha ao salvar o cadastro." +
                    Environment.NewLine +
                    "Erro original: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
