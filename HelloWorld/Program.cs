using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main(string[] qualquercoisa)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (qualquercoisa.Length > 0)
            {
                if (qualquercoisa[0] == "1")
                    Application.Run(new Form1());
                else if (qualquercoisa[0] == "2")
                    Application.Run(new Form2());
                else
                    Application.Run(new Form3());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
