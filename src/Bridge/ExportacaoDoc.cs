using System;

namespace Bridge
{
    public class ExportacaoDoc: ExportacaoImplementor{
        public override void Exportar()
        {
            Console.WriteLine("Exportando arquivo DOC");
        }
    }
}