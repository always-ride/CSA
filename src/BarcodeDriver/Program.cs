namespace BarcodeDriver
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Fake-Modus (Programmaufruf: BarcodeDriver.exe --fake)
            if (args.Length > 1 && args[1] == "--fake")
            {
                string fakeCode = "FAKE123456";
                Console.WriteLine(fakeCode);
                return;
            }

            // Beispiel: COM3; anpassbar via args
            string portName = args.Length > 0 ? args[0] : "COM3";

            var scanner = new SerialScanner(portName);

            // Warten auf den nächsten Scan
            //string scanResult = "TESTBARCODE123";
            var scanResult = await scanner.GetNextScanAsync();

            // Barcode über stdout ausgeben
            Console.WriteLine(scanResult);

            scanner.Close();
        }
    }
}
