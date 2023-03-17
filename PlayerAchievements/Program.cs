using System;

namespace PlayerAchievements {
    
    [Flags]
    public enum Achievement {
        DefeatOptionalBoss = 1 << 0,
        FindHiddenLevel = 1 << 1,
        FinishGame = 1 << 2
    }
    
    class Program {
        static void Main(string[] args) {
            Console.Write("Insert the total of players: ");
            int totalOfPlayers = int.Parse(Console.ReadLine());

            Achievement[] achievementsArray = new Achievement[totalOfPlayers];

            for (int i = 0; i < totalOfPlayers; i++) {
                Console.WriteLine($"\nPlayer {i} Achievements Setup");
                
                Console.Write("Add Defeat Optional Boss (Y/N): ");
                if (Console.ReadLine().ToUpper().Equals("Y"))
                    achievementsArray[i] |= Achievement.DefeatOptionalBoss;
                
                Console.Write("Add Find Hidden Level (Y/N): ");
                if (Console.ReadLine().ToUpper().Equals("Y"))
                    achievementsArray[i] |= Achievement.FindHiddenLevel;
                
                Console.Write("Add Finish Game (Y/N): ");
                if (Console.ReadLine().ToUpper().Equals("Y"))
                    achievementsArray[i] |= Achievement.FinishGame;
            }

            Console.WriteLine();
            
            for (int i = 0; i < totalOfPlayers; i++) {
                Console.WriteLine($"\nPlayer {i} Achievements Display");
                Console.WriteLine(achievementsArray[i]);
                if (HasAchievement(achievementsArray[i], Achievement.FinishGame) &&
                    HasAchievement(achievementsArray[i], Achievement.DefeatOptionalBoss) &&
                    HasAchievement(achievementsArray[i], Achievement.FindHiddenLevel)) 
                {
                    Console.WriteLine("Completionist!");
                }
            } 

        }

        private static bool HasAchievement(Achievement collection, Achievement check) {
            return (collection & check) == check;
        }
        
    }
}