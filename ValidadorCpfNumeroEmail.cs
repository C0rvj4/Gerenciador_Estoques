using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerencia1;

namespace Gerencia1
{


    public class Validador
    {

        public static bool ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentNullException(nameof(cpf), "O CPF não pode ser nulo ou vazio.");

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !long.TryParse(cpf, out long n))
                return false;

            long soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            long resto = soma % 11;
            long digitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (digitoVerificador != cpf[9] - '0')
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            resto = soma % 11;
            digitoVerificador = resto < 2 ? 0 : 11 - resto;

            return digitoVerificador == cpf[10] - '0';

        }



        public static bool ValidarTelefone(string telefone)
        {

            if (string.IsNullOrWhiteSpace(telefone)) 
                throw new ArgumentNullException(nameof(telefone), "O contato não pode ser nulo ou vazio.");

            telefone = telefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            if (telefone.Length != 11 || !long.TryParse(telefone, out long n))
                return true;

            else
            {
                throw new ArgumentException(nameof(telefone), "O Número de telefone não é valido, verifique o número inserido e tente novamente.");

            }
        }

    }
}
