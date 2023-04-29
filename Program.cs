using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    internal static class Projeto1
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Gerente Felipe = new Gerente("Felipe", "127.577.419-93", "48991342824", "Fe25022003");

            Console.WriteLine(Felipe.Senha);

            Console.ReadLine();
        }



    }
}
