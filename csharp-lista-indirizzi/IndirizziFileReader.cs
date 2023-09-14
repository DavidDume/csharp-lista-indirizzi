using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class IndirizziFileReader
    {

        public static Indirizzi ReadFile(string line)
        {
            try
            {
                string[] arr = line.Split(',');

                if (arr.Length >= 6)
                {
                    string name = arr[0];
                    string surname = arr[1];
                    string street = arr[2];
                    string city = arr[3];
                    string province = arr[4];
                    string zip = arr[5];

                    return new Indirizzi(name, surname, street, city, province, zip);
                }
                else
                {

                   throw new Exception($"Errore: mancano dati - '{line}'");
                    return null;

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return null;
            }
        }

    }
}
