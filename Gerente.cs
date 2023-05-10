using System;

namespace Gerencia;

private class Gerencia : Validador

{  
    

     /// <param name="NOME"> Nome do funcionário, deve condizer com o cpf declarado 
    public string Nome { get;}
    /// <param name="SENHA"> Senha de acesso ao sistema, a primeira senha será o nome do funcionário em letras minusculas e sem espaços
    public string Senha { get;}
    ///<param name="CPF"> CPF Do gerente, deve condizer com o nome
    public string Cpf { get;}     
    /// <param name="Contato">Telefone para contato</param>
    public string Contato {get;}
    /// <param name="Matricula"> Registro do sistema interno de cada usuário do tipo gerente (utilizado para cadastro da assinatura digital)</param>
    public int Matricula { get;}


// Gerador -------------------------------------------------------------------------------------------------------------------------------------------------------------
    private static Random random = new Random();
    private static int[] assinaturas = new int[50];
    private static int indice = 0;

    ///<sumary>  
    ///Gera um número de see <see cref="matricula"> o qual será atribuído a um objeto do tipo <see cref="Gerente">
    ///</sumary>
    public int gerador()
    {   
        int gerado = random.Next(100, 1000);
        assinaturas[indice] = gerado;
        indice++;
        Matricula = gerado;
        return Matricula;   
     }


// Construtores -------------------------------------------------------------------------------------------------------------------------------------------------------


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

        int matricula = gerador();
        Nome = nome;
        Cpf = cpf;
        Contato = contato;
        string Senha = nome.Replace(" ", "").ToLower();


        ///<sumary>
        ///Erro exibido quando há letras presentes no <see cref="cpf"> declarado para a criação de um novo gerente
        ///</sumary>
        for (int i = 0; i < nome.Length; i++)
            {if (char.IsDigit(nome[i]) || nome[i] == '1' || nome[i] == '2' || nome[i] == '3' || nome[i] == '4' || nome[i] == '5' || nome[i] == '6' || nome[i] == '7'
                    || nome[i] == '8' || nome[i] == '9') { throw new SystemException(nameoff(nome), "O nome não deve conter numeros");}}

        ///<sumary>
        ///Erro exibido quando há numeros presentes no <see cref="nome"> declarado para a criação de um novo gerente
        ///</sumary>
        for (int i = 0; i < nome.Length; i++)
            {if (char.IsDigit(nome[i]) || nome[i] == ',' || nome[i] == '.' || nome[i] == '-' || nome[i] == ';' || nome[i] == ':' || nome[i] == '!' || nome[i] == '?')
                {throw new SystemException(nameoff(nome), "O nome não deve conter pontuação");}}

        ///<sumary>
        ///Erro exibido quando o <see cref="nome"> é vazio ou nulo
        ///</sumary>
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio");
            
        ///<sumary>
        ///O erro é exibido quando o <see cref="CPF"> não é preenchido (nulo ou vazio)
        ///</sumary>
        if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio");

        ///<sumary>
        ///Ocorre quando o <see cref="contato"> se encontra nulo ou vazio
        ///</sumary>
        if (string.IsNullOrWhiteSpace(contato)) throw new ArgumentNullException(nameof(contato), "O contato não pode ser nulo ou vazio");
        
        ///<sumary>
        ///Erro exibido quando a <see cref="senha" é nula ou vazia
        ///</sumary>
        if (string.IsNullOrWhiteSpace(senha)) throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia");
            

              
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
