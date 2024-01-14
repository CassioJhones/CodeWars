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