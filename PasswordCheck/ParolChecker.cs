using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace PasswordCheck
{
    public class ParolChecker
    {
        public int ChecPassward(string password)
        {
            int score = 0;

            // Проверка на наличие заглавной буквы
            if (password.Any(char.IsUpper))
            {
                score++;
            }

            // Проверка на наличие числа
            if (password.Any(char.IsDigit))
            {
                score++;
            }

            // Проверка на наличие спецсимволов
            if (Regex.IsMatch(password, "[@!@#$%^&*(),.?:{}|<>]"))
            {
                score++;
            }

            // Проверка на длину пароля
            if (password.Length >= 10)
            {
                score++;
            }

            // Проверка на наличие строчной буквы
            if (password.Any(char.IsLower))
            {
                score++;
            }

            return score;

        }
    }
}