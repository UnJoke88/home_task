using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_game;

/// <summary>
/// Класс, управляющий логикой игры "Угадай число".
/// </summary>
public class GuessNumberGame
{
    private INumberGenerator numberGenerator;
    private IInputProvider inputProvider;
    private int targetNumber;
    private int attempts;

    /// <summary>
    /// Создает новую игру с заданным генератором чисел и способом ввода.
    /// </summary>
    /// <param name="generator">Объект генерации случайного числа.</param>
    /// <param name="input">Объект получения ввода пользователя.</param>
    public GuessNumberGame(INumberGenerator generator, IInputProvider input)
    {
        numberGenerator = generator;
        inputProvider = input;
        targetNumber = numberGenerator.GenerateNumber();
        attempts = 0;
    }

    /// <summary>
    /// Запускает игру и управляет игрой сообщениями.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("Привет! Давай играть в 'Угадай число'!");

        while (true)
        {
            int guess = inputProvider.GetUserGuess();
            attempts = attempts + 1;

            if (guess == targetNumber)
            {
                Console.WriteLine("Ура! Ты угадал число на " + attempts + " попытку!");
                break;
            }

            if (guess < targetNumber)
            {
                Console.WriteLine("Мало! Попробуй еще.");
            }

            if (guess > targetNumber)
            {
                Console.WriteLine("Много! Попробуй еще.");
            }
        }
    }
}
