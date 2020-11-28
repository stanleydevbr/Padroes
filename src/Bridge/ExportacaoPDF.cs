using System;

namespace Bridge
{
    public class ExportacaoPDF: ExportacaoImplementor {
        public override void Exportar()
        {
            Console.WriteLine("Exportando arquivo PDF");
        }
    }
}