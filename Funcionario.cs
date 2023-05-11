using System;

namespace Gerencia
{
    public class Funcionario : Validador
    {
        public string Cpf {get;}
        public string Nome {get;}
        public string Senha {get;}
        /// <param name="MatriculaGerente"> Registro do sistema interno de cada usuário do tipo funcionário (utilizado para identificação)
        public int MatriculaFuncionario {get;}
    
    list<Funcionario> ListaFuncionario = new list<Funcionario>();
    


    private static Random random = new Random();
    private static int[] ListaMatriculasFuncionario = new int[50];
    private static int indice = 0;

    ///<sumary>  
    ///Gera um número de see <see cref="matricula"> o qual será atribuído a um objeto do tipo <see cref="Gerente">
    ///</sumary>
    public int gerador()
    {   
        int gerado = random.Next(100, 400);
        ListaMatriculasFuncionario[indice] = gerado;
        indice++;
        MatriculaFuncionario = gerado;
        return MatriculaFuncionario;   
     }

        public Funcionario(string nome, string cpf, List<Funcionario> funcionario)
        {

        if (!ValidarCpf(cpf))
            {
                throw new ArgumentException("O CPF digitado é inválido. Verifique e tente novamente.", nameof(cpf));
            }
            Cpf = cpf;
            Nome = nome;
            Senha = Nome.Replace(" ", "").ToLower();
            funcionario.add(this);
            


       



// Erros nome  ========================================================================================
       
        if (TemNumeros(nome))  {throw new SystemException("O nome não deve conter números.");}

        if (TemPontuacao(nome)) {throw new SystemException("O nome não deve conter pontuação.");}

        if (string.IsNullOrWhiteSpace(nome)) {throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio.");}

// Erros CPF  ===========================================================================================

        if (string.IsNullOrWhiteSpace(cpf))  {throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio.");}     

        if(Temletras(cpf)) {throw new ArgumentException(nameof (cpf),"O  nao deve conter letras");}


// Erros Senha    ========================================================================================    
            

        if (string.IsNullOrWhiteSpace(senha))  {throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia.");}
        
        }


// Metodos  ==============================================================================================

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

                foreach(char c in text)
                {
                        if (Char.IsAsciiLetter)
                        return true;
                }
               return false;
        }
                
                
                
                
        }
}
