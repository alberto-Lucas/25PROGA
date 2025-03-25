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
    }
}
