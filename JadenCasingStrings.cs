string jaden = "How can mirrors be real if our eyes aren't real";
string[] fraseCortada = jaden.Split(' ');
string fraseCompleta = "";

foreach (string palavra in fraseCortada)
{
    char capturaLetraInicial = palavra[0];
    char letraMaiuscula = char.ToUpper(capturaLetraInicial);
    string Frase = letraMaiuscula + palavra.Substring(1);
    fraseCompleta += $"{Frase} ";
}

Console.WriteLine($"Not Jaden-Cased: \"{jaden}\"");
Console.WriteLine($"Jaden-Cased:     \"{fraseCompleta.TrimEnd()}\"");