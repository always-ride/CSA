using System;
using System.Collections.Generic;

namespace MyFirstApp
{
    public class YieldExample
    {
        public static void Execute()
        {
            var countries = new List<Country>
            {
                new Country { Name = "Schweiz", Capital = "Bern" },
                new Country { Name = "Deutschland", Capital = "Berlin" },
                new Country { Name = "Frankreich", Capital = "Paris" },
                new Country { Name = "Fiktivland", Capital = "Bern" }
            };

            foreach (var country in GetCountriesWithCapitalBern2(countries))
            {
                Console.WriteLine(country.Name);
            }
        }

        // Beispiel für eine Iterator-Methode mit yield
        public static IEnumerable<Country> GetCountriesWithCapitalBern(List<Country> countries)
        {
            foreach (var c in countries)
            {
                if (c.Capital == "Bern")
                {
                    // liefert das Element zurück, aber behält den Zustand der Methode
                    yield return c;
                }
            }
        }

        public static IList<Country> GetCountriesWithCapitalBern2(List<Country> countries)
        {
            var result = new List<Country>();

            foreach (var c in countries)
            {
                if (c.Capital == "Bern")
                {
                    result.Add(c);
                }
            }
            return result;
        }

        public class Country
        {
            public string Name { get; set; }
            public string Capital { get; set; }
        }
    }
}
