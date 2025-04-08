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
                MessageBox.Show(
                    "Registro salvo com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
    }
}
