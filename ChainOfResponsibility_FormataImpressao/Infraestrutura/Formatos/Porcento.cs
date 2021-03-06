using ChainOfResponsibility_RetornaFormatoDeImpressao.Dominio;
using ChainOfResponsibility_RetornaFormatoDeImpressao.Interface;
using System;
using System.Linq;
using System.Reflection;

namespace ChainOfResponsibility_FormataImpressao.Infraestrutura.Formatos
{
    public class Porcento : IFormataDadosBancarios
    {
        public IFormataDadosBancarios Proximo { get; set; }

        public void FormataDadosBancarios(string formato, Conta conta)
        {
            if ("PORCENTO".Equals(formato.ToUpper()))
            {
                Type itemType = typeof(Conta);
                var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.SetProperty);

                var porcentagem = string.Join("% ", props.Select(p => p.Name));
                porcentagem += System.Environment.NewLine + string.Join("% ", conta.Nome, conta.Agencia, conta.ContaBancaria, conta.Saldo);

                Console.WriteLine(porcentagem);
                Console.ReadKey();
            }
            else
                Proximo.FormataDadosBancarios(formato, conta);
        }
    }
}
