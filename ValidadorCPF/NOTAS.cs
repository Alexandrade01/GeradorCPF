using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCPF
{
    class NOTAS
    {
        //          No Brasil existe o CPF(Cadastro de Pessoas Físicas) que serve para identificar cada indivíduo no país.
        //  O número do CPF é composto de 11 dígitos, sendo os dois últimos os dígitos de verificação. A fórmula
        //  para verificar a validade do número do CPF é simples e é explicada abaixo:
        //Vamos tomar como exemplo o número de CPF 123.456.789-09
        //• Calculando o 1º Dígito Verificador
        //  Primeiro calculamos a soma da multiplicação dos 9 primeiros dígitos por 10, 9, 8, ... , 3, 2,
        //  respectivamente.Ou seja:
        //Soma = (1 * 10) + (2 * 9) + ... + (8*3) + (9*2)
        //Depois calculamos o resto da divisão de soma por 11:
        //Resultado = Soma módulo 11.
        //Agora analisamos Resultado:
        //• Se Resultado for igual a 0 ou 1, então o 1º dígito verificador deve ser 0;
        //• Caso contrário, o 1º dígito verificador é calculado com a fórmula: 11 - Resultado.
        //• Calculando o 2º Dígito Verificador
        //Primeiro calculamos a soma da multiplicação dos 9 primeiros dígitos por 11, 10, 9, ... , 4, 3,
        //respectivamente e em seguida somamos com(Digito1*2), sendo que Digito1 é o valor encontrado
        //para o 1º dígito verificador.Ou seja:
        //Soma = (1*11) + (2*10) + ... + (8*4) + (9*3) + (Digito1*2)
        //Depois calculamos o resto da divisão de soma por 11:
        //Resultado = Soma módulo 11.
        //Agora analisamos Resultado:
        //• Se Resultado for igual a 0 ou 1, então o 2º dígito verificador deve ser 0;
        //• Caso contrário, o 2º dígito verificador é calculado com a fórmula: 11 - Resultado.

        //exemplo(123.456.789-09) o número é válido.
    }
}
