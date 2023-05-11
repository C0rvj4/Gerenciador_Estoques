using System;

namespace Gerencia;

private class Gerencia : Validador

{  
    

     /// <param name="Nome"> Nome do funcionário, deve condizer com o cpf declarado 
    public string Nome { get;}
    /// <param name="GerenteSenha"> Senha de acesso ao sistema, a primeira senha será o nome do funcionário em letras minusculas e sem espaços
    public string GerenteSenha { get;}
    ///<param name="Cpf"> CPF Do gerente, deve condizer com o nome
    public string Cpf { get;}     
    /// <param name="Contato">Telefone para contato</param>
    public string Contato {get;}
    /// <param name="GerenteMatricula"> Registro do sistema interno de cada usuário do tipo gerente (utilizado para cadastro da assinatura digital)</param>
    public int GerenteMatricula { get;}


// Gerador De Matricula =================================================================================================================================
    private static Random random = new Random();
    private static int[] LitaMatriculasGerente = new int[50];
    private static int indice = 0;

    ///<sumary>  
    ///Gera um número de see <see cref="matricula"> o qual será atribuído a um objeto do tipo <see cref="Gerente">
    ///</sumary>
    public int gerador()
    {   
        int gerado = random.Next(500, 1000);
        LitaMatriculasGerente[indice] = gerado;
        indice++;
        Matricula = gerado;
        return Matricula;   
     }


// Construtores ================================================================================================================================


        /// <summary>
        /// Cria um objeto Gerente com acesso total ao sistema.
        /// </summary>
        /// <param name="nome">O nome do gerente (identificação apenas)</param>
        /// <param name="cpf">O CPF do gerente (será usado como login do sistema)</param>
        /// <param name="contato">O e-mail ou telefone para contato do gerente</param>
        /// <param name="senha">A senha de acesso ao sistema do gerente</param>
        /// <exception cref="ArgumentNullException">Lançada se algum dos argumentos for nulo ou vazio</exception>
    public Gerente(string nome, string cpf, string contato, string senha)
    {           
        if (!this.ValidarCpf(cpf))
            throw new ArgumentException(nameof(cpf), "O cpf não é valido");
        else(Cpf = cpf);

        if(!this.ValidarTelefone(contato))
            throw new ArgumentException(nameoff(contato),"O numero de celular não é valido, verifique e tente novamente.");
        else (Contato = contato);

        int matricula = gerador();
        Nome = nome;
        string Senha = nome.Replace(" ", "").ToLower();


// Erros Nome =================================================================================================================================
    

        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio.");

        if (TemNumeros(nome)) throw new ArgumentException(nameoff(nome), "O nome não pode conter número.");
            

// Erros CPF ===================================================================================================================================
      
      
        if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio.");

        if (TemLetras(cpf)) throw new ArgumentException(nameoff(cpf), "O cpf não pode conter letras.");


// Erros Contato ================================================================================================================================  
     
     
        if (string.IsNullOrWhiteSpace(contato)) throw new ArgumentNullException(nameof(contato), "O contato não pode ser nulo ou vazio.");


 // Erros Senha =================================================================================================================================   
      
      
        if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia.");
            



// Metodos  =======================================================================================================================================
        }

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
        ///<sumary>
        /// Verifica se a GerenteSenha fornecida confere com a GerenteMatricula do objeto <see cref="Gerencia"> fornecido.
        ///<param name="GerenteMatricula"> A matricula do gerente o qual está utilizando o sistema.
        ///<param name="GerenteSenha"> Senha do Objeto gerente que está utilizando o sistena
        ///<returns> Reetorna um Bool sendo False = não confere, true = Confere</returns> 
        ///</sumary>
        private bool VerificarSenha(int GerenteMatricula, string GerenteSenha)
        {
        Gerente gerente = ObterGerentePorMatricula(matricula);
            if (gerente != null && gerente.Senha == senha) 
            {return true;} 
            else {return false;}
        }   

        ///<sumary>
        /// Atribui a nova senha ao funcionário.
        ///<param name="MatriculaFuncionario"> A matricula do objeto <see cref="Funcionario"> a qual esta sendo alterada.
        ///<param name="NovaSenhaFuncionario"> A Nova senha a qual será atribuída.
        ///</sumary>
        private string AtribuiSenha(int MatriculaFuncionario, string NovaSenhaFuncionario) 
        {
        Funcionario FuncionarioEncontrado = ListaFuncionario.FirstOrDefault(g => g.MatriculaFuncionario == MatriculaFuncionario);
        if  (Funcionario != null) {
        Funcionario.Senha = novaSenha;
        Console.WriteLine("Senha alterada com sucesso!");} 
        else {Console.WriteLine("Gerente não encontrado!");}
        }

        
        ///<sumary>
        /// Troca a senha de um objeto do tipo <see cref="Funcionario">
        private void TrocaSenha(int GerenteMatricula, string SenhaGerente, int MatriculaFuncionario, string SenhaAntigaFuncionario, string NovaSenhaFuncionario)
        {
            
            // procurando a matricula inserida  
            bool encontrou = false;
            for (int i = 0; i < LitaMatriculasGerente.Length; i++) 
            {
            if (numeros[i] == GerenteMatricula) {encontrou = true;}
            }

             // liberando o acesso
            if(encontrou == true)
                {return("Acesso liberado");}
            else
                {return("Apenas Gerentes podem alterar senhas");break;}

            // Verificando se a senha confere com a matricula    
            bool VerificarSenha(int GerenteMatricula, string SenhaGerente);

            // Liberando acesso
            if(VerificarSenha == true )
            {return ($"A senha confere, Gerente {GerenteMatricula}");}
            else throw new ArgumentException(nameoff(SenhaGerente), "A senha provida não confere com a matricula, confira e tente novamente");

            // Atribui a nova senha ao funcionário 
            if(VerificarSenha == true && encontrou == true)
            {
                 void AtribuiSenha(int MatriculaFuncionario, string NovaSenhaFuncionario);
            }

            

        } 
    
        
    
    

// Funções -----------------------------------------------------------------------------------------------------------------------------------------------------------------------










































            // Métodos
            // - Cadastro de funcionários --- Em andamento
            // - Entradas
            // - Saídas
            // - Consulta de guias
            // - Relatórios mensais e anuais
            // - Alterar login e senha --- Em andamento
            // - Cadastro de empresa parceira
            // - Cadastro de novos produtos
            // - Exclusão de guia
