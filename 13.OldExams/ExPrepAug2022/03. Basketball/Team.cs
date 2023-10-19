using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public List<Player> Players { get; private set; }
        public int Count { get { return Players.Count; } } //Getter

        public string AddPlayer(Player player)
        {
            if (OpenPositions > 0)
            {
                if (player.Name == null || player.Name == "" || player.Position == null || player.Position == "")
                {
                    return "Invalid player's information.";
                }
                if (player.Rating < 80)
                {
                    return "Invalid player's rating.";
                }
                OpenPositions--;
                Players.Add(player);
                return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }
            return "There are no more open positions.";
        }
        public bool RemovePlayer(string name)
        {
            if (Players.Any(x => x.Name == name))
            {
                Players.RemoveAll(x => x.Name == name);
                OpenPositions++;
                return true;
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)
        {
            int plrsCount = 0;
            if (Players.Any(x => x.Position == position))
            {
                foreach (var player in Players)
                {
                    if (player.Position == position)
                    {
                        plrsCount++;
                    }
                }
                Players.RemoveAll(x => x.Position == position);
                OpenPositions += plrsCount;
                return plrsCount;
            }
            return 0;
        }

        public Player RetirePlayer(string name)
        {
            if (Players.Any(x => x.Name == name))
            {
                Players.First(x => x.Name == name).Retired = true;
                return Players.First(x => x.Name == name);
            }
            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> awardedPlayers = new List<Player>();
            foreach (var player in Players)
            {
                if (player.Games >= games)
                {
                    awardedPlayers.Add(player);
                }
            }
            return awardedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var player in Players)
            {
                if (!player.Retired)
                {
                    sb.AppendLine(player.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
