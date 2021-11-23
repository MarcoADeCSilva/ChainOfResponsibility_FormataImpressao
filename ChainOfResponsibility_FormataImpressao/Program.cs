using ChainOfResponsibility_FormataImpressao.Servico;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;
using System;

namespace ChainOfResponsibility_FormataImpressao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.Nome = "Marco Aurélio";
            conta.Agencia = "1529";
            conta.ContaBancaria = "094946";
            conta.Saldo = 500;

            RetornaContaEmDiferentesFormatos formata = new RetornaContaEmDiferentesFormatos();
            formata.Formata("XML", conta);
            formata.Formata("CSV", conta);
            formata.Formata("PORCENTO", conta);
        }
    }
}
