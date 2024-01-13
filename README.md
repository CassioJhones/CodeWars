<img src="https://www.codewars.com/users/CassioJhones/badges/large" /> 

##  Isograms

An isogram is a word that has no repeating letters, consecutive or non-consecutive.<br/>Implement a function that determines whether a string that contains only letters is an isogram.<br/>Assume the empty string is an isogram. Ignore letter case.

Exemple:
```csharp
isIsogram "Dermatoglyphics" = true
isIsogram "moose" = false
isIsogram "aba" = false
```

### ✅ Feito no Visual Studio
<details>
<summary>Abrir Código</summary>
 
```csharp
public class Kata
{
    public static bool IsIsogram(string str)
    {
        string stringRecebida = str.ToLower();

        //Coleção tipo HashSet não permite adicionar nada repetido, Coleção do tipo Lista Permite
        HashSet<char> LetrasEncontradas = [];
        List<char> listaDeLetras = new();

        foreach (char letra in stringRecebida)
        {
            if (LetrasEncontradas.Contains(letra))
                return false; // Não é Isograma pois tem letra repetida

            LetrasEncontradas.Add(letra);
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("Dermatoglyphics"));
        Console.WriteLine(IsIsogram("moose"));
        Console.WriteLine(IsIsogram("aba"));
    }
}
```

</details>

### ✅ Adaptado pro CodeWars
<details>
<summary>Abrir Código</summary>
 
```csharp
using System;
using System.Collections.Generic;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        string stringRecebida = str.ToLower();

        //Coleção tipo HashSet não permite adicionar nada repetido, Coleção do tipo Lista Permite
        HashSet<char> LetrasEncontradas = new HashSet<char>();

        foreach (char letra in stringRecebida)
        {
            if (LetrasEncontradas.Contains(letra))
                return false; // Não é Isograma pois tem letra repetida

            LetrasEncontradas.Add(letra);
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("Dermatoglyphics"));
        Console.WriteLine(IsIsogram("moose"));
        Console.WriteLine(IsIsogram("aba"));
    }
}
```

</details>

##  Jaden Casing Strings

Jaden Smith, filho de Will Smith, é estrela de filmes como The Karate Kid (2010) e After Earth (2013). Jaden também é conhecido por algumas de suas filosofias que transmite via Twitter . Ao escrever no Twitter, ele é conhecido por quase sempre colocar cada palavra em maiúscula. Para simplificar, você terá que colocar cada palavra em maiúscula, veja como são esperadas as contrações no exemplo abaixo.
Sua tarefa é converter strings para como seriam escritas por Jaden Smith. As strings são citações reais de Jaden Smith, mas não estão em maiúsculas da mesma forma que ele as digitou originalmente.

Exemplo:
```sql
Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
```

### ✅ Feito no Visual Studio
<details>
<summary> Abrir Código </summary>
 
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

</details>

### ✅ Adaptado pro CodeWars
<details>
<summary> Abrir Código </summary>
 
```csharp
using System;
using System.Collections.Generic;
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
```

</details>

<!--  ![Codewars](https://github.r2v.ch/codewars?user=CassioJhones&stroke=%23BB432C)-->
