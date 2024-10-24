using System;
using System.Runtime.ConstrainedExecution;


public class InvoiceGenerator
{
    public void GenerateInvoice()
    {
        //tymczasowe pola zmienione na lokalne zmienne
        int invoiceNumber = 12345;
        PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

        // Generowanie faktury
        pdfWriter.Write("Invoice Content");
        pdfWriter.Close();
    }

    public void OtherMethod()
    {
        // Metoda, która nie korzysta z tymczasowych zmiennych
    }
}


