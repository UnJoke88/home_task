using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_game;

/// <summary>
/// Интерфейс для получения ввода от пользователя.
/// </summary>
public interface IInputProvider
{
    /// <summary>
    /// Получает число пользователя.
    /// </summary>
    /// <returns>Число, введенное пользователем.</returns>
    int GetUserGuess();

    /// <summary>
    /// Получает выборанный уровень сложности от пользователя.
    /// </summary>
    /// <returns>Выбранный уровень сложности.</returns>
    DifficultyLevel GetDifficultyChoice();
}
