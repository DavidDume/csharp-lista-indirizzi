// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;

List<Indirizzi> indirizzi = new List<Indirizzi>(); 

try
{
    StreamReader fileIndirizzi = File.OpenText("C:\\Users\\David\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

    int lineNumber = 1;

    while (!fileIndirizzi.EndOfStream)
    {
        string line = fileIndirizzi.ReadLine();
        lineNumber++;
        Console.WriteLine(line);
        Indirizzi indirizzo = IndirizziFileReader.ReadFile(line);
        indirizzi.Add(indirizzo);
    }

    fileIndirizzi.Close();

}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}

//Console.WriteLine(indirizzi);