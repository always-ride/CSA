using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyThirdApp
{
    public class LoggingDemo
    {
        public static void Execute()
        {
            // Setup Dependency Injection für Logging
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure =>
                {
                    configure.ClearProviders();
                    configure.AddConsole();
                    configure.SetMinimumLevel(LogLevel.Information);
                })
                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();

            // Reguläre Log-Level Beispiele
            logger.LogTrace("Trace-Meldung");
            logger.LogDebug("Debug-Meldung");
            logger.LogInformation("Information");
            logger.LogWarning("Warnung");
            logger.LogError("Fehler");
            logger.LogCritical("Kritischer Fehler");

            // Debug-spezifische Methode
            DebugOnlyMessage("Dies erscheint nur im Debug-Build");

            // Beispiel für Tracing eines Prozesses
            Task.Run(() => DoWork(logger)).Wait();
        }

        private static void DoWork(ILogger logger)
        {
            logger.LogInformation("Starte DoWork...");
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    logger.LogDebug("Bearbeite Schritt {Step}", i);
                    DebugOnlyMessage($"Debug: Schritt {i} ausgeführt"); // nur Debug
                    if (i == 2)
                        throw new InvalidOperationException("Fehler bei Schritt 2");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ein Fehler ist während DoWork aufgetreten");
            }
            finally
            {
                logger.LogInformation("DoWork abgeschlossen");
            }
        }

        // Methode, die nur in Debug-Builds ausgeführt wird
        [Conditional("DEBUG")]
        private static void DebugOnlyMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
