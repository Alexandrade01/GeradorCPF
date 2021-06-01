using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCPF
{
    class validadores
    {
        public int Digito1(string numero)
        {
            int cont = 0;
            int soma = 0;
            int resto = 0;
            int digito1 = 0;
            for (int x = 10; x >= 2; x--)
            {

                soma += Convert.ToInt32(numero[cont].ToString())*x;
                cont++;
                
            }


            resto = soma % 11;
            if(resto == 0 || resto == 1)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }

            return digito1;

        }

        public int Digito2(string numero)
        {
            int soma = 0;
            int cont = 0;
            int resto = 0;
            int digito2 = 0;
            for (int x = 11; x >= 3; x--)
            {

                soma += Convert.ToInt32(numero[cont].ToString()) * x;
                cont++;

            }

            soma += Digito1(numero)*2;
            resto = soma % 11;
            if (resto == 0 || resto == 1)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }

            return digito2;
        }

        public bool TamanhoDigitos(int primeirodigito, int segundodigito)
        {
            bool validador = true;
            if(primeirodigito>10 || primeirodigito < 0 || segundodigito>10 || segundodigito<0)
            {
                validador = false;
            }
            return validador;
        }
    }
}
