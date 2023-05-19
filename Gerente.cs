using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Gerencia1
{

    public class Gerente 
    {


        /// <param name="GerenteNome"> Nome do funcionário, deve condizer com o cpf declarado 
        public string GerenteNome { get; }
        /// <param name="GerenteSenha"> Senha de acesso ao sistema, a primeira senha será o nome do funcionário em letras minusculas e sem espaços
        public string GerenteSenha { get; }
        ///<param name="Cpf"> CPF Do gerente, deve condizer com o nome
        public string GerenteCpf { get; }
        /// <param name="Contato">Telefone para contato</param>
        public string GerenteContato { get; }
        /// <param name="GerenteMatricula"> Registro do sistema interno de cada usuário do tipo gerente (utilizado para cadastro da assinatura digital)</param>
        public int GerenteMatricula { get; private set; }

        List<int> ListaMatriculaGerente = new List<int>();




        // Construtores ======================================================================================================================================================================


        /// <summary>
        /// Cria um objeto Gerente com acesso total ao sistema.
        /// </summary>
        /// <param name="GerenteNome">O nome do gerente (identificação apenas)</param>
        /// <param name="GerenteCpf">O CPF do gerente (será usado como login do sistema)</param>
        /// <param name="GerenteContato">O e-mail ou telefone para contato do gerente</param>
        /// <param name="GerenteSenha">A senha de acesso ao sistema do gerente</param>
        /// </sumary>
        public Gerente(string _GerenteNome, string _GerenteCpf, string _GerenteContato)
        {

            GerenteCpf = _GerenteCpf;
            // Valida o CPF e atribui ao Objeto;
            if (Validador.ValidarCpf(GerenteCpf))
            {
                Console.WriteLine("O cpf é valido");
            }

            // gera uma matricula aleatória e atribui o Objeto;
            int Gerentematricula = gerador();

            // Formata o nome inserido retirando espaços e pontuações para não haver erros;
            GerenteNome = FormatarNome(_GerenteNome);

            // Atribui como senha padrão o nome formatado e em Caixa alta; 
            GerenteSenha = FormatarNome(_GerenteNome);

        }
        // Metodos  =========================================================================================================================================================================


        public static bool TemNumeros(string text)
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

        public static bool TemPontuacao(string text)
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


        public static bool TemLetras(string text)
        {

            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                    return true;
            }
            return false;
        }

        public static string FormatarNome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), "O nome não pode ser nulo ou vazio.");

            if (TemNumeros(text))
                throw new SystemException("O nome não deve conter números.");

            text = text.ToLower().Trim();

            var sb = new StringBuilder();

            foreach (char c in text)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();


        }

        public int gerador()
        {
            Random r = new Random();
            int gerado = r.Next(500, 1000);
            ListaMatriculaGerente.Add(gerado);
            GerenteMatricula = gerado;
            return GerenteMatricula;
        }
    }
}


        ///<sumary>  
        ///Gera um número de see <see cref="matricula"> o qual será atribuído a um objeto do tipo <see cref="Gerente">
        ///</sumary>




        ///<sumary>
        /// Verifica se a GerenteSenha fornecida confere com a GerenteMatricula do objeto <see cref="Gerencia"> fornecido.
        ///<param name="GerenteMatricula"> A matricula do gerente o qual está utilizando o sistema.
        ///<param name="GerenteSenha"> Senha do Objeto gerente que está utilizando o sistena
        ///<returns> Reetorna um Bool sendo False = não confere, true = Confere</returns> 
        ///</sumary>
       /* public string VerificarSenha(int GerenteMatricula, string GerenteSenha)
        {
            Gerente gerente = ListaMatriculaGerente.Find(g => g.GerenteMatricula == this.GerenteMatricula && g.GerenteSenha == GerenteSenha) ;
            if (gerente != null)
            {
                return ($"A senha confere, Gerente {GerenteMatricula}");
            }
            else
            {
                throw new ArgumentException(nameof(GerenteSenha), "A senha provida não confere com a matricula, confira e tente novamente");
            }
        }

        ///<sumary>
        /// Atribui a nova senha ao funcionário.
        ///<param name="MatriculaFuncionario"> A matricula do objeto <see cref="Funcionario"> a qual esta sendo alterada.
        ///<param name="NovaSenhaFuncionario"> A Nova senha a qual será atribuída.
        ///</sumary>
        public void AtribuiSenha(int MatriculaFuncionario, string NovaSenhaFuncionario)
        {
            Funcionario FuncionarioEncontrado = ListaFuncionario.FirstOrDefault(g => g.MatriculaFuncionario == MatriculaFuncionario);
                
        }

        // Funções   ====================================================================================================================================================================        


        ///<sumary>
        /// Troca a senha de um objeto do tipo <see cref="Funcionario">
        private string TrocaSenha(int GerenteMatricula, string SenhaGerente, int MatriculaFuncionario, string SenhaAntigaFuncionario, string NovaSenhaFuncionario)
        {
            bool encontrou = false;
            // procurando a matricula inserida  
            for (int i = 0; i < ListaMatriculaGerente.Count; i++)
            {
                if (ListaMatriculaGerente[i] == GerenteMatricula) { encontrou = true; }
                
            }

            // liberando o acesso
            if (encontrou == true)
            { return ("Acesso liberado"); }
            if (encontrou == false)
            { return ("Apenas Gerentes podem alterar senhas"); }

            // Verificando se a senha confere com a matricula    
            VerificarSenha(GerenteMatricula,SenhaGerente);

            AtribuiSenha(MatriculaFuncionario,NovaSenhaFuncionario);

            return ("Senha alterada com sucesso.");
        }
    }
}





//lembrete : criar uma classe com metodos de estenção do tipo string para tratamento de strings// */
