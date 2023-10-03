using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string cmd;
            List<Trainer> trainers = new List<Trainer>();

            while ((cmd = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArr = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = cmdArr[0];
                string pokemonName = cmdArr[1];
                string pokemonElement = cmdArr[2];
                int pokemonHealth = int.Parse(cmdArr[3]);
                if (!trainers.Any(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers.First(trainer => trainer.Name == trainerName).AcollectionOfPokemon.Add(pokemon);
            }

            string cmd2;

            while ((cmd2 = Console.ReadLine()) != "End")
            {
                if (cmd2 == "Fire")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.AcollectionOfPokemon.Any(pokemon => pokemon.Element == "Fire"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.AcollectionOfPokemon)
                            {
                                pokemon.Health -= 10;
                            }
                        }
                        trainer.AcollectionOfPokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                else if (cmd2 == "Water")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.AcollectionOfPokemon.Any(pokemon => pokemon.Element == "Water"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.AcollectionOfPokemon)
                            {
                                pokemon.Health -= 10;
                            }
                        }
                        trainer.AcollectionOfPokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                else if (cmd2 == "Electricity")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.AcollectionOfPokemon.Any(pokemon => pokemon.Element == "Electricity"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.AcollectionOfPokemon)
                            {
                                pokemon.Health -= 10;
                            }
                        }
                        trainer.AcollectionOfPokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }

                }
            }
            foreach (Trainer trainer in trainers.OrderByDescending(tr => tr.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.AcollectionOfPokemon.Count}");
            }
        }
    }
}