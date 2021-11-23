using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Interface;
using System;
using System.Xml.Serialization;

namespace ChainOfResponsibility_FormataImpressao.Infraestrutura.Formatos
{
    public class XML : IFormataDadosBancarios
    {
        public IFormataDadosBancarios Proximo { get; set; }

        public void FormataDadosBancarios(string formato, Conta conta)
        {
            if ("XML".Equals(formato.ToUpper()))
            {
                XmlSerializer xml = new XmlSerializer(conta.GetType());
                xml.Serialize(Console.Out, conta);
                Console.WriteLine();
                Console.ReadKey();
            }
            else
                Proximo.FormataDadosBancarios(formato, conta);
        }
    }
}
