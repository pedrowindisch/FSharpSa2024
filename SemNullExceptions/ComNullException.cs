using System;
using System.Collections.Generic;

public class Program
{
	public record Filme(string Nome, double Avaliacao);					

    public static Filme RetornaPrimeiraAvaliacaoMenorQueSete(IEnumerable<Filme> filmes) 
    {
        foreach (var filme in filmes)
            if (filme.Avaliacao < 7)
                return filme;

        return null;
    }
	
	public static void Main()
	{
        IEnumerable<Filme> jeanLucGodard = [
            new Filme("Pierrot Le Fou", 8.9), 
            new Filme("Vivre sa vie", 7.1), 
            new Filme("Il disprezzo", 9.6), 
            new Filme("Masculin Feminin", 7.8)
        ];
		
		var filmeRuim = RetornaPrimeiraAvaliacaoMenorQueSete(jeanLucGodard);
		Console.WriteLine($"Um dos filmes possui avaliação menor que sete: {filmeRuim.Nome}");
	}
}