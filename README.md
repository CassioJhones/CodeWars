# CodeWars

##  Jaden Casing Strings

Jaden Smith, filho de Will Smith, é estrela de filmes como The Karate Kid (2010) e After Earth (2013). Jaden também é conhecido por algumas de suas filosofias que transmite via Twitter . Ao escrever no Twitter, ele é conhecido por quase sempre colocar cada palavra em maiúscula. Para simplificar, você terá que colocar cada palavra em maiúscula, veja como são esperadas as contrações no exemplo abaixo.
Sua tarefa é converter strings para como seriam escritas por Jaden Smith. As strings são citações reais de Jaden Smith, mas não estão em maiúsculas da mesma forma que ele as digitou originalmente.

Exemplo:
```sql
Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
```
### Teste no Visual Studio ✅

```csharp
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
```
### Enviado no CodeWars ✅
```csharp
global using global::System;
global using global::System.Collections.Generic;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    string[] fraseCortada = phrase.Split(' ');
    List<string> FraseUnida = new List<string>();
    string fraseCompleta = "";

    foreach (string palavra in fraseCortada)    
    {   
        char capturaLetraInicial = palavra[0];
        char letraMaiuscula = char.ToUpper(capturaLetraInicial);
        string Frase = letraMaiuscula + palavra.Substring(1);   
        fraseCompleta += $"{Frase} ";
    }
    return fraseCompleta.Trim();
  }
}
