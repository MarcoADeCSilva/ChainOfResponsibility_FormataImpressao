using ChainOfResponsibility_FormataImpressao.Infraestrutura.Formatos;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Interface;

namespace ChainOfResponsibility_FormataImpressao.Servico
{
    public class RetornaContaEmDiferentesFormatos
    {
        public void Formata(string formato, Conta conta)
        {
            IFormataDadosBancarios f1 = new XML();
            IFormataDadosBancarios f2 = new CSV();
            IFormataDadosBancarios f3 = new Porcento();
            IFormataDadosBancarios fDefault = new Default();

            f1.Proximo = f2;
            f2.Proximo = f3;
            f3.Proximo = default;

            f1.FormataDadosBancarios(formato, conta);
        }        
    }
}
