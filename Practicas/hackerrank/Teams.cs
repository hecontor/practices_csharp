using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.hackerrank
{
    public class Team
    {

        public string teamName;
        private int noOfPlayers;

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        public void AddPlayer(int count)
        {
            this.noOfPlayers += count;
        }
        public bool RemovePlayer(int count)
        {
            if (this.noOfPlayers - count < 0) return false;
            else
                this.noOfPlayers -= count;
            return true;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers){ }
        public void ChangeTeamName(string name)
        {
            this.teamName = name;
        }

        public static string AppendAndDelete(string s, string t, int k)
        {
            int commonLength = 0;
            int minLength = Math.Min(s.Length, t.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (s[i] == t[i])
                    commonLength++;
                else
                    break;
            }

            int minOperations = (s.Length - commonLength) + (t.Length - commonLength);


            if (minOperations <= k && (k - minOperations) % 2 == 0 || s.Length + t.Length <= k)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
