using System.IO.Ports;

namespace BarcodeDriver
{
    // TODO implement IDIsposable
    public class SerialScanner
    {
        private readonly SerialPort port;
        private TaskCompletionSource<string>? tcs;

        public SerialScanner(string portName, int baudRate = 9600)
        {
            port = new SerialPort(portName, baudRate);
            port.DataReceived += Port_DataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = port.ReadLine().Trim();
                tcs?.TrySetResult(line);
            }
            catch { }
        }

        public async Task<string> GetNextScanAsync()
        {
            tcs = new TaskCompletionSource<string>();
            if (!port.IsOpen) port.Open();
            return await tcs.Task;
        }

        public void Close()
        {
            if (port.IsOpen) port.Close();
        }
    }
}
