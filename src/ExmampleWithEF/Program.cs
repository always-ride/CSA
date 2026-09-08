namespace ExmampleWithEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            var message = "";
            using (var db = new AppDbContext())
            {
                // Datenbank erstellen, falls noch nicht vorhanden
                db.Database.EnsureCreated();

                // Neues Produkt anlegen
                db.Products.Add(new Product { Name = "Laptop", Price = 999.99m, Stock = 5 });
                db.SaveChanges();

                // Alle Produkte abfragen
                var products = db.Products.OrderBy(p => p.Name).ToList();

                Console.WriteLine("--- Produkte ---");
                foreach (var p in products)
                    Console.WriteLine($"{p.Id}: {p.Name} – {p.Price:C} ({p.Stock} Stück)");

                // Ein Produkt aktualisieren
                var laptop = db.Products.First(p => p.Name == "Laptop");
                laptop.Stock -= 1;
                db.SaveChanges();

                message = $"\nNach Verkauf: {laptop.Name} hat noch {laptop.Stock} Stück";
            }
            Console.WriteLine(message);
        }
    }
}
