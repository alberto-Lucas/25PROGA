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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();

            //Nescessario desativar
            //a auto validação
            //para que o sistema não 
            //cancele uma ação escencial
            //como o Fechamento da tela
            AutoValidate = AutoValidate.Disable;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //Aqui iremos criar a validação
            //e notificação, exclusivamente
            //para o campo txtNome

            //Validar se o campo esta preenchido
            if(string.IsNullOrEmpty(txtNome.Text))
            {
                //Marcar o cancelameto
                //da excução
                //Ex: parar a execução
                //do botão salvar
                e.Cancel = true;
                //definir a mensagem a ser
                //exibida para o usuario
                errProvider.SetError(
                    txtNome, "Preencha o Nome");
            }
            else
            {
                //Preciso cancelar o cancelamento
                e.Cancel= false;
                //Limpar a mensagem de erro
                errProvider.SetError(
                    txtNome, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Iremos validar se possui algum
            //cancelamento

            //Se não tiver cancelamento
            //confirmar a gravação dos dados
            //para o usuario

            //Se tiver apresentar mensagem ao 
            //usuario

            //Validamos se algum
            //filho(componente em tela)
            //possui uma solicitação de
            //cancelamento
            if(ValidateChildren(
                ValidationConstraints.Enabled))
            {
                /*
                MessageBox.Show(
                    "Registro salvo com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                */
                Salvar();
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Preencha todos os " +
                    "campos corretamente!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Na ação do botão Cancelar
            //Iremos deixar a decisão por
            //parte do usuario
            
            //Iremos apresentar uma mensagem 
            //de SIM ou NÃO
            //Para confirmação do cancelamento
            //da alteração
            //MessageBoxButtons.YesOrNo 
            //para definir a opção de SIM ou Não
            //Precisamos definir o botão padrão
            //que recebera o foco
            //e sera acionado ao pressionar o 
            //ENTER do teclado
            //MessageBoxDefaultButton.button2
            //O foco do botão será na opçõa NÃO
            //para evitar do cliente confirmar
            //a operação sem ler a mensagem
            //Validar o retorno da mensagem
            //DialogResult.Yes para validar
            //se o usuario clicou em SIM
            if(MessageBox.Show(
                "Deseja realmente descartar "+
                "as alterações?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Se o usuario clicar em SIM
                //fecho a tela
                Close();
            }
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            lblCPF.Text = mskCPF.Text;
        }

        string SoNumero(string pTexto)
        {
            string retorno = "";

            for (int i = 0; i < pTexto.Length; i++)
            {
                //Usar o IsNumber para ignorar
                //o - do CPF
                if (char.IsNumber(pTexto[i]))
                {
                    retorno += pTexto[i];
                }
            }
            return retorno;
        }

        private void mskCPF_Validating(object sender, CancelEventArgs e)
        {
            //Iremos remover a mascara
            //do CPF
            string CPF = SoNumero(mskCPF.Text);

            //Agora podemos validar
            if(string.IsNullOrEmpty(CPF))
            {
                e.Cancel = true;
                errProvider.SetError(
                    mskCPF, "Preencha o CPF.");
            }
            //Validar se tem a quantidade correta
            //de numero
            else if(CPF.Length != 11)
            {
                e.Cancel= true;
                errProvider.SetError(
                    mskCPF, 
                    "Preenche o CPF corretamente");
            }
            else
            {
                //Esse encerramento é obrigatorio
                //em todos eventos VALIDATING
                e.Cancel = false;
                errProvider.SetError(
                    mskCPF, "");
            }
        }

        //Função que valida o arquivo
        bool ArquivoExiste(string caminho)
        {
            //Iremos validar a existencia do arquivo
            //lembrando que o nome do arquivo será o CPF
            //portanto se um arquivo ja existir
            //significa que ja possui um cadastro 
            //de cliente com aquele CPF
            //retornando a existencia do arquivo
            // Verifica se o arquivo já existe
            return File.Exists(caminho);
        }

        //Método para gravar o arquivo
        void GravarArquivo(string caminho, string conteudo)
        {
            //Iremos para a rotina de gravação do arquivo
            //Caso for o primeiro cadastro a pasta 
            //do cadastro não deve existir
            //para isso precisamos validar se o caminho existe
            //se não existir iremos criar

            //OBS: Não usamos o Try aqui
            //pois foi usado na rotina anterior

            // Cria o diretório se não existir
            string pasta = Path.GetDirectoryName(caminho);
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Grava o conteúdo no arquivo
            File.WriteAllText(caminho, conteudo);
        }

        //Função que retorna o caminho do arquivo
        string GetDirArquivo(string tipoCadastro, string nomeArquivo)
        {
            //O caminho será montado:
            //Diretorio Raiz do executavel
            //tipo do cadastro: Clientes
            //Nome arquivo: CPF do cliente
            //Ex: C:/Programas/AppCadastros/Clientes/00000000000.txt

            // Diretório raiz do executável
            string diretorioRaiz = AppDomain.CurrentDomain.BaseDirectory;

            return
                Path.Combine(diretorioRaiz, tipoCadastro, nomeArquivo + ".txt");
        }

        //Função que retorna o cadastro em forma de Conteudo
        string GetCadastro()
        {
            //Iremos concatenar o cadastro
            //para o conteudo do arquivo
            string cadastro =
                "CPF: " + mskCPF.Text +
                Environment.NewLine +
                "NOME: " + txtNome.Text +
                Environment.NewLine +
                "DATA_NASCIMENTO: " + dtpDataNascimento.Text +
                Environment.NewLine +
                "RG: " + txtRG.Text;

            return cadastro;
        }

        //Método para Salvar o Cadastro
        void Salvar()
        {
            //Recuperamos o caminho completo
            //Onde iremos definir o tipo do cadastro: Clientes
            //e o nome do arquivo: CPF
            //precisamos do só numero para remover a mascara do CPF
            string caminhoCompleto = 
                GetDirArquivo("Cliente", SoNumero(mskCPF.Text));

            //Primeira coisa validar a existencia do arquivo
            if(ArquivoExiste(caminhoCompleto))
            {
                MessageBox.Show(
                    "Já existe um cadastro com este CPF.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Agora iremos tentar gravar o cadastro no arquivo
            try
            {
                GravarArquivo(caminhoCompleto, GetCadastro());

                //Iremos apresentar o diretorio apenas para
                //teste interno
                //No programa final o usuário nao deve saber
                //onde o arquivo foi salvo
                MessageBox.Show(
                    "Registro salvo com sucesso!" + Environment.NewLine +
                    Environment.NewLine + "Salvo em: " + caminhoCompleto,
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha ao salvar o cadastro." + Environment.NewLine +
                    "Erro original: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
