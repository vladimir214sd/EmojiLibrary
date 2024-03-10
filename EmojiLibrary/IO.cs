using System;
namespace EmojiLibrary
{
	public interface IO
	{
        public static int InputValidNumber(int a, int b)  // проверка на целое число
        {
            int element;
            bool isConvert;

            do
            {
                Console.Write("Введите значение: ");
                isConvert = int.TryParse(Console.ReadLine(), out element) && element >= a && element <= b;

                if (!isConvert)
                    Console.Write($"Ошибка при вводе! Введите значение от {a} до {b}: ");
            } while (!isConvert);
            return element;
        }
    }
}

