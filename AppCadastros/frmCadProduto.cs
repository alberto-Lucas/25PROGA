using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
            //Desativa a validação autmatica
            //Iremos ativar somente no botão SALVAR
            AutoValidate = AutoValidate.Disable;
        }

        private void txtDescricao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                e.Cancel = true;
                errErro.SetError(txtDescricao,
                    "Preencha a Descrição do produto.");
            }
            else
            {
                e.Cancel = false;
                errErro.SetError(txtDescricao, "");
            }
        }

        private void mskCodBarras_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(mskCodBarras.Text))
            {
                e.Cancel = true;
                errErro.SetError(mskCodBarras,
                    "Preencha o Código de Barras.");
            }
            else
            {
                if(mskCodBarras.Text.Length != 13)
                {
                    e.Cancel = true;
                    errErro.SetError(mskCodBarras,
                        "Informe um Código de Barras válido.");
                }
                else
                {
                    e.Cancel= false;
                    errErro.SetError(mskCodBarras, "");
                }
            }
        }

        private void cbbUnidade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(cbbUnidade.Text))
            {
                e.Cancel = true;
                errErro.SetError(cbbUnidade,
                    "Selecione uma Unidade.");
            }
            else
            {
                e.Cancel = false;
                errErro.SetError(cbbUnidade, "");
            }
        }

        private void cbbGrupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(cbbGrupo.Text))
            {
                e.Cancel = true;
                errErro.SetError(cbbGrupo,
                    "Selecione um Grupo.");
            }
            else
            {
                e.Cancel = false;
                errErro.SetError(cbbGrupo, "");
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Precisa identificar o
            //caracter pressionado

            char ch = e.KeyChar; //Caracte pressionado

            //Validar SE NÃO FOR caracter esperado
            //numeros e virgula
            //Permitir:
            //Numeros 0-9, virgula, TAB,
            //BackSpace e o ENTER
            //Iremos ignora o caracter

            //8 = BackSpace
            //9 = TAB
            //13 = ENTER
            if(!char.IsDigit(ch) && 
                ch != 8 && ch != 13 && 
                ch != ',' && ch != 9)
            {
                //Se entrou é pq não é permitido
                //aborta o pressionar da tecla
                e.Handled = true; 
                //MessageBox opicional
            }
            //Se chegou até aqui, o caracter é permitdo
            //e sera adicionado ao campo
        }

        private void txtPrecoVenda_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                e.Cancel = true;
                errErro.SetError(txtPrecoVenda,
                    "Preencha o Preço de Venda.");
            }
            else
            {
                //Antes de valida o valor negativo ou 0
                //preciso converter para decimal
                decimal precoVenda = 
                    decimal.Parse(txtPrecoVenda.Text);

                if(precoVenda <= 0)
                {
                    e.Cancel = true;
                    errErro.SetError(txtPrecoVenda,
                        "Informe um valor maior que zero.");
                }
                else
                {
                    e.Cancel = false;
                    errErro.SetError(txtPrecoVenda, "");
                }
            }
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if(ValidateChildren(
                ValidationConstraints.Enabled))
            {
                MessageBox.Show(
                    "Registro salvo com sucesso.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Preencha os campos corretamente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtCancelar_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show(
                "Deseja realmente descartar as alterações?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
