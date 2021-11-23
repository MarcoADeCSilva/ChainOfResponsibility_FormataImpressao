using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Interface;
using System;

namespace ChainOfResponsibility_FormataImpressao.Infraestrutura.Formatos
{
    public class Default : IFormataDadosBancarios
    {
        public IFormataDadosBancarios Proximo { get; set; }

        public void FormataDadosBancarios(string formato, Conta conta)
        {
            Console.WriteLine("Formato não reconhecido pelo sistema. Tente novamente");
            Console.ReadKey();
        }
    }
}
