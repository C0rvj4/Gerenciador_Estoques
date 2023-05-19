using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gerencia1
{
    public class Funcionario
    {
        public string FuncionarioCpf { get; }
        public string FuncionarioNome { get; }
        public string FuncionarioSenha { get; }
        /// <param name="MatriculaGerente"> Registro do sistema interno de cada usuário do tipo funcionário (utilizado para identificação)
        public int MatriculaFuncionario { get; }


        // Contrutor ===================================================================================================================================================================

        public Funcionario(string _Funcionarionome, string _FuncionarioCpf, List<Funcionario> funcionario)
        {
            // Valida o CPF e atribui ao Objeto
            if (Validador.ValidarCpf(_FuncionarioCpf))
            {
                FuncionarioCpf = _FuncionarioCpf;
            }
            
            FuncionarioNome =  Gerente.FormatarNome(_Funcionarionome);
            FuncionarioSenha = Gerente.FormatarNome(this.FuncionarioNome);
            

        }



        // Metodos  ====================================================================================================================================================================

        private bool TemNumeros(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool TemPontuacao(string text)
        {
            foreach (char c in text)
            {
                if (char.IsPunctuation(c))
                {
                    return true;
                }
            }
            return false;
        }


        private bool TemLetras(string text)
        {

            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                    return true;
            }
            return false;
        }




    }
}
