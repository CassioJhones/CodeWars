public class Kata
{
	public static bool IsIsogram(string str)
	{
		string stringRecebida = str.ToLower();

		//Cole��o tipo HashSet n�o permite adicionar nada repetido, Cole��o do tipo Lista Permite
		HashSet<char> LetrasEncontradas = [];
		List<char> listaDeLetras = new();

		foreach (char letra in stringRecebida)
		{
			if (LetrasEncontradas.Contains(letra))
				return false; // N�o � Isograma pois tem letra repetida

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