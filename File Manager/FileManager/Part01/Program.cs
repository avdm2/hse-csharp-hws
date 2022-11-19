using System;
using System.Text;
using System.IO;

public partial class Program
{
    /// <summary>
    /// Основной метод. Точка входа.
    /// </summary>
    static void Main(string[] args)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        ConsoleKey repeatKey = 0;
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в консольное приложение \"Файловый менеджер\".");
                Console.WriteLine("Для начала проследуйте в интересующую директорию.");
                Console.WriteLine("На Вашем компьютере были обнаружены следующие диски:");
                // Пользователь выбирает диск.
                SelectDrive(out string selectedDrive);
                // После выбора диска пользователь проходит через множество папок. Для этого используем следующий метод.
                GoThroughDirectoriesAndGetFiles(in selectedDrive, out string currentPath, out bool filesInDirectory);
                // Получаем из предыдущего метода значение переменной filesInDirectory, и если оно истинно, т.е. в директории есть 
                // файлы, то идем дальше.
                if (filesInDirectory)
                {
                    //Выбор файла, с которым пользовател будет работать.
                    SelectFile(in currentPath, out string[] files, out int fileNumber);
                    //Вывод функций приложения.
                    AppFunctions();
                    bool correctInput = false;
                    do
                    {
                        // Значение correctInput отвечает за правильность введенного пользователем номера операции, 
                        // которая будет произведена над ранее выбранным им файлом. Помимо этого, сам метод ChooseAnOperation 
                        // запускает метод операции, которую выбрал пользователь.
                        correctInput = ChooseAnOperation(ref files, ref fileNumber);
                    } while (!correctInput);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка! {ex.Message}");
                Console.ForegroundColor = defaultColor;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Для повторного использования нажмите \"Enter\". Для выхода - любую другую клавишу.");
            Console.ForegroundColor = defaultColor;
            repeatKey = Console.ReadKey().Key;
        } while (repeatKey == ConsoleKey.Enter);
    }
}

