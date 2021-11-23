using System.Xml.Serialization;

namespace ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio
{
    public class Conta
    {
        public string Nome { get; set; }       
        public string Agencia { get; set; }
        public string ContaBancaria { get; set; }
        public decimal Saldo { get; set; }
    }
}
