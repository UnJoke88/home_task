using System.Security.Cryptography;

namespace numbers_game;

/// <summary>
/// Main класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Запускает игру "Угадай число".
    /// </summary>
    static void Main()
    {
        ConsoleInputProvider input = new ConsoleInputProvider();
        DifficultyLevel difficulty = input.GetDifficultyChoice();

        int maxNumber;
        if (difficulty == DifficultyLevel.Easy)
        {
            maxNumber = 100;
        }
        else
        {
            maxNumber = 1000;
        }

        RandomNumberGenerator generator = new RandomNumberGenerator(maxNumber);
        GuessNumberGame game = new GuessNumberGame(generator, input);
        game.Start();
    }
}
