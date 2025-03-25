using System.Windows.Forms;

namespace AtividadeTabuada
{
    public partial class Form1 : Form
    {
        //Aceitar somente numero inteiros
        //Validar se o numeros são maiores
        //que zero e menores que cem
        //se nao forem, exibir uma mensagem
        //alertando o usuario
        //validar se o segundo numero
        //é meio que o primeiro
        //se não for, exibir mensagem ao usuario
        //utilizar comando for para exibir
        //o resultado no listbox
        public Form1()
        {
            InitializeComponent();
        }

        //Função que retorna se uma string
        //é somente numero inteiro
        bool IsNumeroInteiro(string valor)
        {
            //Primeiro validar se o valor
            //não esta vazio

            if (valor == "")          
                return false; //encerro a funcao
            
            //Criar o laço repetição
            //para validar os caracteres 
            //da string, passandor
            //caracter por caracter
            for(int i = 0; i < valor.Length; i++)
            {
                //Verificar se o caracter atual
                //é um digito
                //Neste caso se não for digito
                //ja retornamos falso
                //! significa negação
                if (!char.IsDigit(valor[i]))
                    return false;
            }

            //se chegamos até aqui
            //significa que o valor informa
            //é um numero inteiro
            //entamos podemos retornoar True
            return true;
        }

        //Função para validar o intervalo
        bool IsIntervaloValido(int valor)
        {
            //Estou retornando o resultado
            //direto na condição
            //Validar o intervalo
            //&& significa o E da tabela verdade
            //|| significo o OU da tabela verdade
            return (valor > 0 && valor < 100);
        }

        //Função para retornar os campos validos
        //Centralizar as validações com mensagem
        bool IsCamposValidos(
            string valorInicial, string valorFinal)
        {
            //Validar ser o campo Inicial 
            //é somente numero inteiro
            //Usamos a negação ! pois iremos
            //apresentar apenas a mensage
            //se o valor for invalido
            if(!IsNumeroInteiro(valorInicial))
            {
                MessageBox.Show(
                    "Informe um número Inicial válido.");
                return false; //encerro a função
            }

            if (!IsNumeroInteiro(valorFinal))
            {
                MessageBox.Show(
                    "Informe um número Final válido.");
                return false; //encerro a função
            }

            //Neste momento temos a certeza,
            //que os valores Inicial e Final são 
            //numero inteiros
            //então modemos converter a string para int
            int iInicial = int.Parse(valorInicial);
            int iFinal = int.Parse(valorFinal);

            //Validação se o valor
            //esta dentro do intervalo
            if(!IsIntervaloValido(iInicial))
            {
                MessageBox.Show(
                    "Informe um número "+
                    "Inicial maior que 0(zero) " +
                    "e menor que cem(100).");
                return false;
            }

            if (!IsIntervaloValido(iFinal))
            {
                MessageBox.Show(
                    "Informe um número " +
                    "Final maior que 0(zero) " +
                    "e menor que cem(100).");
                return false;
            }

            //Validação se o numero Final é maior 
            //que o numero inicial
            if(iFinal <= iInicial)
            {
                MessageBox.Show(
                    "Informe um número Final " +
                    "maior que o número Inicial.");
                return false;
            }

            //Se chegou até aqui, tod as validações
            //acima são verdadeiras
            //ou seja os valores informados, são validos
            return true;
        }

        //Método para calcular a tabuada
        void CalcularTabuada(
            int valorInicial, int valorFinal)
        {
            //Primeiro limpados o listBox
            lstResultado.Items.Clear();

            //Criar um laço de repetição
            //que ira passar por cada valor
            //do intervalo
            //Ou seja temos intervalo do 2 ao 4
            //Então iremos passar pelo 2 depois 
            //pelo 3 e depois pelo 4
            for(int i = valorInicial; i <= valorFinal; i++)
            {
                //A cada passada do intervalo
                //iremos calcular a tabuada do valor
                //de 1 a 10
                //Ou seja de for o intervalo 3
                //Iremos calcular a tabuada do 3
                //do 1 ao 10
                for(int j = 1; j <= 10; j++)
                {
                    //Criar um varial para armazenar
                    //o resultado do calculo atual

                    //Ex: i x j = (i*j)
                    //Ex: 2 x 1 = 2
                    string resultado;
                    resultado =
                        i.ToString() + " x " +
                        j.ToString() + " = " +
                        (i * j).ToString();

                    //Adicionar o resultado ao listBox
                    lstResultado.Items.Add(resultado);
                }
                //A cada intervalo será adicionado
                //uma linha para sepração
                lstResultado.Items.Add("------------");
            }
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            //Validar se o valor inserido
            //é valido
            //Usaremos negação, pois se tiver 
            //Invalido encerramos a execução
            if (!IsCamposValidos(
                txtNumInicial.Text, txtNumFinal.Text))
            {
                //por ser um método
                //o return é vazio
                return;
            }

            //Se tiver tudo ok, podemos o conver o valor
            int iInicial = int.Parse(txtNumInicial.Text);
            int iFinal = int.Parse(txtNumFinal.Text);

            //Podemos calcular a tabuada
            CalcularTabuada(iInicial, iFinal);
        }
    }
}
