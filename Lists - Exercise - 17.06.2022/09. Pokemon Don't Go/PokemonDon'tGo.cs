using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfCatchedPokemonsValue = 0;
            int pokemonValue = 0;



            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());


                if (index >= 0 && index <= pokemons.Count - 1)
                {
                    pokemonValue = pokemons[index];

                    pokemons.RemoveAt(index);
                }
                else
                {
                    if (index < 0)
                    {
                        index = 0;
                        pokemonValue = pokemons[index];
                        pokemons.RemoveAt(index);
                        pokemons.Insert(index, pokemons[pokemons.Count - 1]);
                    }

                    if (index > pokemons.Count - 1)
                    {
                        index = pokemons.Count - 1;
                        pokemonValue = pokemons[index];
                        pokemons.RemoveAt(index);
                        pokemons.Insert(index, pokemons[0]);
                    }
                }

                sumOfCatchedPokemonsValue += pokemonValue;

                for (int currentIndex = 0; currentIndex < pokemons.Count; currentIndex++)
                {
                    if (pokemonValue >= pokemons[currentIndex])
                    {
                        pokemons[currentIndex] += pokemonValue;
                    }
                    else
                    {
                        pokemons[currentIndex] -= pokemonValue;
                    }
                }
            }

            Console.WriteLine(sumOfCatchedPokemonsValue);
        }
    }
}
