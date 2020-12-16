namespace _06.TournamentOfChristmas
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double countWinCurencyTotal = 0;
            double countWinCurencyForDay = 0;
            int countWinGame = 0;
            int countLoseGame = 0;

            int dayWin = 0;
            int dayLose = 0;

            for (int i = 0; i < number; i++)
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Finish")
                    {
                        break;
                    }

                    string winLose = Console.ReadLine();

                    if (winLose == "win")
                    {
                        countWinCurencyForDay += 20;
                        countWinGame++;
                    }
                    else if (winLose == "lose")
                    {
                        countLoseGame++;
                    }
                }

                if (countWinGame > countLoseGame)
                {
                    countWinCurencyForDay *= 1.1;
                    countWinCurencyTotal += countWinCurencyForDay;
                    countWinCurencyForDay = 0;
                    dayWin++;
                }
                else
                {
                    countWinCurencyTotal += countWinCurencyForDay;
                    countWinCurencyForDay = 0;
                    dayLose++;
                }

                countWinGame = 0;
                countLoseGame = 0;
            }

            if (dayWin > dayLose)
            {
                countWinCurencyTotal *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {countWinCurencyTotal:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {countWinCurencyTotal:F2}");
            }
        }
    }
}
