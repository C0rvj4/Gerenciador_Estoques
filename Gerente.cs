using System;

namespace Projeto1
{
    public class Gerente
    {
        // Campos
        public string Nome { get; }
        public string CPF { get; }
        public string Contato { get; }
        public string Senha { get; }


        // Gerados aleatoriamente -----------------------------------------------------------------
        /// <summary>
        /// <param name="Assinatura"> Assinatura digital individual (usada para assinar documentos)</param>
        /// </summary>
        public string Assinatura { get; set; }
        /// <summary>
        /// <param name="Matricula">Registro do sistema interno de cada usuário do tipo gerente (utilizado para cadastro da assinatura digital)</param>
        /// 
        /// </summary>
        public int Matricula { get; set; }
        //------------------------------------------------------------------------------------------




        // Construtor -------------------------------------------------------------------------------
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
            if (String.Contains("." || "-"))
                throw new SyntaxErrorException(nameof(cpf), "O CPF deve ser declarado sem pontuação");
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio");
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio");
            if (string.IsNullOrWhiteSpace(contato))
                throw new ArgumentNullException(nameof(contato), "O contato não pode ser nulo ou vazio");
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia");

            Nome = nome;
            CPF = cpf;
            // Proxima implementação (Será criado um validador de CPF para confirmação a veracidade do mesmo)
            Contato = contato;
            // Proxima implementação (Será enviado um número de confirmação ao e-mail ou telefone informado para validação)
            Senha = senha;
        }
        //---------------------------------------------------------------------------------------------


        // Métodos
        // - Cadastro de funcionários
        // - Entradas
        // - Saídas
        // - Consulta de guias
        // - Relatórios mensais e anuais
        // - Alterar login e senha
        // - Cadastro de empresa parceira
        // - Cadastro de novos produtos
        // - Exclusão de guia
    }
}
