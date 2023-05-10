using System;

namespace Gerencia
{
    public class Funcionario : Validador
    {
        public string Cpf { get; }
        public string Nome { get; }
        public string Senha { get; }

        public Funcionario(string nome, string cpf)
        {
            if (!ValidadorCPF(cpf))
            {
                throw new ArgumentException("O CPF inserido não é válido.");
            }

            Cpf = cpf;
            Nome = nome;
            Senha = Nome.Replace(" ", "").ToLower();

            if (!ValidarCpf(cpf))
            {
                throw new ArgumentException("O CPF digitado é inválido. Verifique e tente novamente.", nameof(cpf));
            }

            if (TemNumeros(nome))
            {
                throw new SystemException("O nome não deve conter números.");
            }

            if (TemPontuacao(nome))
            {
                throw new SystemException("O nome não deve conter pontuação.");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia.");
            }
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
