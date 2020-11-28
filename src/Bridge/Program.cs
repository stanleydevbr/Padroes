using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Exportacao pdf = new ExportacaoExtensao();
            pdf.Implementor = new ExportacaoPDF();
            pdf.Exportar();

            Exportacao doc = new ExportacaoExtensao();
            doc.Implementor = new ExportacaoDoc();
            doc.Exportar();

        }
    }
}
