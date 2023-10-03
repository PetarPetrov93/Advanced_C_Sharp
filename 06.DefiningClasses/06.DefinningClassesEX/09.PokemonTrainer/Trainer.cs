using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> aCollectionOfPokemon = new();

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }
        public List<Pokemon> AcollectionOfPokemon
        {
            get { return aCollectionOfPokemon; }
            set { aCollectionOfPokemon = value; }
        }
    }
}
