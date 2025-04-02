using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_game;

/// <summary>
/// Класс генерации случайных чисел.
/// </summary>
public class RandomNumberGenerator : INumberGenerator
{
    private int maxValue;
    private Random random;

    /// <summary>
    /// Генератор случайных чисел с заданным максимальным значением.
    /// </summary>
    /// <param name="maximum">Максимальное значение для генерации числа.</param>
    public RandomNumberGenerator(int maximum)
    {
        maxValue = maximum;
        random = new Random();
    }

    /// <summary>
    /// Генерирует случайное число от 1 до максимального значения.
    /// </summary>
    /// <returns>Случайное число.</returns>
    public int GenerateNumber()
    {
        return random.Next(1, maxValue + 1);
    }
}