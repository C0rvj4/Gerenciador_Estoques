using System;

namespace Gerencia;
 public class Funcionario : Validador
        {       

        ///<sumary>
        ///O cpf deve ser válido e condizer com o nome inserido.
        ///</sumary>
        string Cpf { get;}
        ///<sumary>
        ///Nome do funcionário, deve condizer com o cpf
        ///</sumary>
        string Nome { get;}
        ///<sumary>
        ///Senha de acesso ao sistema. A primeira senha será o nome da pessoa, sem espaços e em letras minusculas
        ///<sumary>
        string Senha { get;}
    
 public Funcionario (string nome, string Cpf)
        {
                if(!this.ValidadorCPF(cpf)) {return("O CPF inserido não é valido");} else {cpf=Cpf;}
                Nome = nome;
                Senha = Nome.Replace(" ", "").ToLower();

        ///<sumary>
        ///Exceção exibida quando o CPF foi digitado incorretamente ou não existe.
        ///</sumary>
        if(!this.ValidarCpf(cpf)) throw new ArgumentException(nameof(cpf),"O CPF digita é invalido, verifique e tente novamente");   

               ///<sumary>
        ///Erro exibido quando há letras presentes no <see cref="cpf"> declarado para a criação de um novo gerente
        ///</sumary>
        for (int i = 0; i < nome.Length; i++)
            { if (char.IsDigit(nome[i]) || nome[i] == '1' || nome[i] == '2' || nome[i] == '3' || nome[i] == '4' || nome[i] == '5' || nome[i] == '6' || nome[i] == '7'
                    || nome[i] == '8' || nome[i] == '9')
                { throw new SystemException(nameoff(nome), "O nome não deve conter numeros");} }

        ///<sumary>
        ///Erro exibido quando há numeros presentes no <see cref="nome"> declarado para a criação de um novo gerente
        ///</sumary>
        for (int i = 0; i < nome.Length; i++)
            {if (char.IsDigit(nome[i]) || nome[i] == ',' || nome[i] == '.' || nome[i] == '-' || nome[i] == ';' || nome[i] == ':' || nome[i] == '!' || nome[i] == '?')
                {throw new SystemException(nameoff(nome), "O nome não deve conter pontuação");} }

        ///<sumary
        ///Erro exibido quando o <see cref="nome"> é vazio ou nulo
        ///</sumary>
        if (string.IsNullOrWhiteSpace(nome))throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio");
        ///<sumary>
        ///O erro é exibido quando o <see cref="CPF"> não é preenchido (nulo ou vazio)
        ///</sumary>
        if (string.IsNullOrWhiteSpace(cpf))throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio");
        ///<sumary>
        ///Erro exibido quando a <see cref="senha" é nula ou vazia
        ///</sumary>
        if (string.IsNullOrWhiteSpace(senha))throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia");

        }

    




        //funções//

        //Entradas,
        //Saídas,
        //consulta de guias,
        //relatórios mensais, anuais
        //consulta de produtos e estoque
        //consulta de cógdigos 
    
}
