using System.Diagnostics;

class Program
{
    static void Main()
    {
        var exePath = @"C:\Users\digicomp\source\repos\CSA\src\BarcodeDriver\bin\Debug\net10.0\BarcodeDriver.exe";
        var port = "COM3";

        var process = new Process();
        process.StartInfo.FileName = exePath;
        process.StartInfo.Arguments = $"{port} --fake" ;
        //process.StartInfo.Arguments = $"{port}";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;

        process.Start();

        Console.WriteLine("Warte auf gescannten Barcode...");

        // Liest die Ausgabe (scanResult) synchron
        string? scanResult = process.StandardOutput.ReadLine();

        Console.WriteLine($"Empfangener Barcode: {scanResult ?? "<no barcode received>"}");

        process.WaitForExit();
    }
}
