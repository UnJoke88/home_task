using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_game;

/// <summary>
/// Интерфейс для генерации чисел.
/// </summary>
public interface INumberGenerator
{
    /// <summary>
    /// Генерирует число.
    /// </summary>
    /// <returns>Сгенерированное число.</returns>
    int GenerateNumber(); 
}
