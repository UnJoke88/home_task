using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_game;

/// <summary>
/// Класс для получения ввода от пользователя через консоль.
/// </summary>
public class ConsoleInputProvider : IInputProvider
{
    /// <summary>
    /// Запрашивает у пользователя число и проверяет его.
    /// </summary>
    /// <returns>Число, введенное пользователем.</returns>
    public int GetUserGuess()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        int guess;

        while (!int.TryParse(input, out guess))
        {
            Console.Write("Ошибка! Введите число еще раз: ");
            input = Console.ReadLine();
        }

        return guess;
    }

    /// <summary>
    /// Запрашивает у пользователя выбор уровня сложности.
    /// </summary>
    /// <returns>Выбранный уровень сложности.</returns>
    public DifficultyLevel GetDifficultyChoice()
    {
        Console.WriteLine("Выбери сложность: 1 - Легкий (1-100), 2 - Сложный (1-1000)");
        string input = Console.ReadLine();
        int choice;

        while (!int.TryParse(input, out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Ошибка! Введи 1 или 2:");
            input = Console.ReadLine();
        }

        if (choice == 1)
        {
            return DifficultyLevel.Easy;
        }
        else
        {
            return DifficultyLevel.Hard;
        }
    }
}

