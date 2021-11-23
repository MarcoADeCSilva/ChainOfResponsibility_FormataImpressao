using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;

namespace ChainOfResponsibility_RetornaFormatoDeImpressao.Interface
{
    public interface IFormataDadosBancarios
    {
        void FormataDadosBancarios(string formato, Conta conta);
        IFormataDadosBancarios Proximo { get; set; }
    }
}
