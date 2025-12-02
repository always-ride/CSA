using System;
using System.IO;

namespace MyThirdApp
{
    internal class FileIODemo
    {
        public static void Execute()
        {
            string rootPath = @"C:\";
            string outputFile = @"C:\dir_info.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile, false)) // false = überschreiben
                {
                    DirectoryInfo rootDir = new DirectoryInfo(rootPath);
                    ListDirectoryContents(rootDir, writer, "");
                }

                Console.WriteLine($"Die Informationen wurden erfolgreich in {outputFile} geschrieben.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }

        static void ListDirectoryContents(DirectoryInfo dir, StreamWriter writer, string indent)
        {
            // Verzeichnisse durchlaufen
            try
            {
                foreach (DirectoryInfo subDir in dir.EnumerateDirectories())
                {
                    writer.WriteLine($"{indent}[DIR] {subDir.Name}");
                    ListDirectoryContents(subDir, writer, indent + "  ");
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine($"{indent}[DIR] {dir.Name} (Zugriff verweigert)");
                return;
            }
            catch (Exception ex)
            {
                writer.WriteLine($"{indent}[DIR] {dir.Name} (Fehler: {ex.Message})");
                return;
            }

            // Dateien durchlaufen
            try
            {
                foreach (FileInfo file in dir.EnumerateFiles())
                {
                    writer.WriteLine($"{indent}{file.Name} ({file.Length} Bytes)");
                }
            }
            catch (UnauthorizedAccessException)
            {
                writer.WriteLine($"{indent}  (Dateizugriff verweigert)");
            }
            catch (Exception ex)
            {
                writer.WriteLine($"{indent}  (Fehler beim Zugriff auf Dateien: {ex.Message})");
            }
        }
    }
}
