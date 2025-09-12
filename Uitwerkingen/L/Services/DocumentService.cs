using L.Models;

namespace L.Services;

public class DocumentService
{
    private readonly IDrieInEenPrinter _printer;

    public DocumentService(IDrieInEenPrinter printer)
    {
        _printer = printer;
    }

    public void VerwerkDocumentInAdministratie(string documentNaam)
    {
        // Scan het document
        _printer.Scan(documentNaam);

        //Upload het document naar blob storage
        Console.WriteLine($"Upload {documentNaam} naar blob storage");

        // Print een kopie van het document
        _printer.Print(documentNaam);

        // Archiveer een kopie van het het document
        _printer.Kopieer(documentNaam);

        Console.WriteLine($"Klaar met {documentNaam}");
    }
}
