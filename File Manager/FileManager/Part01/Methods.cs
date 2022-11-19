using System;
using System.IO;
using System.Text;

public partial class Program
{
    /// <summary>
    /// Вывод всех операций с файлом, которые может осуществить программа.
    /// </summary>
    private static void AppFunctions()
    {
        Console.WriteLine("В приложении реализованы следующие операции:");
        Console.WriteLine("1. Просмотр содержимого файла в различных кодировках");
        Console.WriteLine("2. Удаление файла");
        Console.WriteLine("3. Копирование файла");
        Console.WriteLine("4. Перемещение файла");
        Console.WriteLine("Для совершения операции введите соответствующую цифру.");
    }

    /// <summary>
    /// Метод выбора пользоваталем операции над файлом.
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static bool ChooseAnOperation(ref string[] files, ref int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        bool correctInput = false;
        switch (Console.ReadLine())
        {
            case "1":
                Console.Clear();
                ReadFile(in files, in fileNumber);
                correctInput = true;
                break;
            case "2":
                DeleteFile(in files, in fileNumber);
                correctInput = true;
                break;
            case "3":
                Console.Clear();
                CopyFile(in files, in fileNumber);
                correctInput = true;
                break;
            case "4":
                Console.Clear();
                MoveFile(in files, in fileNumber);
                correctInput = true;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка! Команды не существует. Повторите ввод.");
                Console.ForegroundColor = defaultColor;
                correctInput = false;
                break;
        }
        return correctInput;
    }

    /// <summary>
    /// Метод для выбора диска, с которым пользователь будет работать в дальнейшем.
    /// </summary>
    /// <param name="selectedDrive">Название выбранного пользователем диска.</param>
    public static void SelectDrive(out string selectedDrive)
    {
        int amountOfDrives = 0;
        ConsoleColor defaultConsoleColor = Console.ForegroundColor;
        // Получаем список дисков.
        string[] drives = Environment.GetLogicalDrives();
        foreach (string s in drives)
        {
            amountOfDrives++;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{amountOfDrives}. {s}");
        }
        Console.ForegroundColor = defaultConsoleColor;
        Console.WriteLine("Выберите диск, с которым хотите работать. Для этого введите порядковый номер диска.");
        bool correctInput = false;
        selectedDrive = null;
        // Проверка на корректность ввода номера диска.
        do
        {
            string inputDrive = Console.ReadLine();
            correctInput = int.TryParse(inputDrive, out int selectedDriveNumber);
            if (!correctInput || selectedDriveNumber <= 0 || selectedDriveNumber > drives.Length)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка! Некорректнный ввод. Повторите попытку.");
                Console.ForegroundColor = defaultConsoleColor;
                correctInput = false;
            }
            else
                selectedDrive = drives[selectedDriveNumber - 1];
        } while (!correctInput);
        Console.Clear();
        Console.Write($"Вами был выбран следующий диск: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(selectedDrive);
        Console.ForegroundColor = defaultConsoleColor;
    }

    /// <summary>
    /// Рекурсивная функция для просмотра всех папок и файлов внутри другой папки.
    /// </summary>
    /// <param name="selectedDrive">Выбранный пользователем диск.</param>
    /// <param name="currentPath">Строка, отображающая путь к текущей папке.</param>
    /// <param name="filesInDirectory">True, если в папке есть файлы, false, если их нет.</param>
    private static void GoThroughDirectoriesAndGetFiles(in string selectedDrive, out string currentPath, out bool filesInDirectory)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        currentPath = selectedDrive;
        string[] directories = Directory.GetDirectories(currentPath);
        GetFiles(currentPath);
        Console.WriteLine();
        int k = 0, folderNumberMemory;
        if (directories.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("В выбранной папке отсутствуют другие директории.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите \"Done\", чтобы продолжить работу в текущей папке.");
            Console.ForegroundColor = defaultColor;
        }
        else
        {
            Console.WriteLine("Выберите папку, с которой будете работать в дальнейшем. Введите ее порядковый номер.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите \"Done\", чтобы продолжить работу в текущей папке.");
            Console.ForegroundColor = defaultColor;
        }
        foreach (string directory in directories)
        {
            k++;
            Console.WriteLine($"{k}. {directory}");
        }
        bool parseCheck = false;
        string memoryInput;
        do
        {
            string input = Console.ReadLine();
            bool correctParse = int.TryParse(input, out int folderNumber);
            if (input == "Done")
            {
                memoryInput = input;
                break;
            }
            else
            {
                if (!correctParse || folderNumber <= 0 || folderNumber > directories.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    Console.ForegroundColor = defaultColor;
                }
                else
                {
                    folderNumberMemory = folderNumber;
                    parseCheck = true;
                    currentPath = directories[folderNumberMemory - 1];
                }
            }
            folderNumberMemory = folderNumber;
            memoryInput = input;
        } while (!parseCheck || folderNumberMemory <= 0 || folderNumberMemory > directories.Length);
        if (memoryInput == "Done")
        {
            filesInDirectory = false;
            try
            {
                filesInDirectory = GetFiles(currentPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.Clear();
            GoThroughDirectoriesAndGetFiles(in currentPath, out currentPath, out filesInDirectory);
        }
    }

    /// <summary>
    /// Рекурсивная функция для просмотра всех папок.
    /// </summary>
    /// <param name="selectedDrive">Выбранный пользователем диск.</param>
    /// <param name="selectedPath">Строка, отображающая путь к текущей папке.</param>
    private static void GoThroughDirectoriesAndGetPath(in string selectedDrive, out string selectedPath)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        selectedPath = selectedDrive;
        string[] directories = Directory.GetDirectories(selectedPath);
        Console.WriteLine();
        int k = 0, folderNumberMemory;
        if (directories.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("В выбранной папке отсутствуют другие директории.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите \"Done\", чтобы скопировать \\ переместить файл в текущую папку.");
            Console.ForegroundColor = defaultColor;
        }
        else
        {
            Console.WriteLine("Выберите папку, в которую будете копировать \\ перемещать файл. Введите ее порядковый номер.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите \"Done\", чтобы скопировать \\ переместить файл в текущую папку.");
            Console.ForegroundColor = defaultColor;
        }
        foreach (string directory in directories)
        {
            k++;
            Console.WriteLine($"{k}. {directory}");
        }
        bool parseCheck = false;
        string memoryInput;
        do
        {
            string input = Console.ReadLine();
            bool correctParse = int.TryParse(input, out int folderNumber);
            if (input == "Done")
            {
                memoryInput = input;
                break;
            }
            else
            {
                if (!correctParse || folderNumber <= 0 || folderNumber > directories.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                    Console.ForegroundColor = defaultColor;
                }
                else
                {
                    folderNumberMemory = folderNumber;
                    parseCheck = true;
                    selectedPath = directories[folderNumberMemory - 1];
                }
            }
            folderNumberMemory = folderNumber;
            memoryInput = input;
        } while (!parseCheck || folderNumberMemory <= 0 || folderNumberMemory > directories.Length);
        if (memoryInput != "Done")
        {
            Console.Clear();
            GoThroughDirectoriesAndGetPath(in selectedPath, out selectedPath);
        }
    }

    /// <summary>
    /// Метод для получения файлов в папке.
    /// </summary>
    /// <param name="currentPath">Строка, отображающая путь к текущей папке.</param>
    private static bool GetFiles(string currentPath)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        bool filesInDirectory;
        Console.Clear();
        Console.Write($"Вами был выбран следующий путь: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(currentPath);
        Console.ForegroundColor = defaultColor;
        Console.WriteLine("Файлы в папке:");
        string[] files = Directory.GetFiles(currentPath);
        int numberOfTheFile = 0;
        filesInDirectory = true;
        if (files.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("В директории нет файлов!");
            Console.ForegroundColor = defaultColor;
            filesInDirectory = false;
        }
        else
        {
            foreach (string file in files)
            {
                numberOfTheFile++;
                if (file != "")
                    Console.WriteLine($"{numberOfTheFile}. {file}");
            }
        }

        return filesInDirectory;
    }

    /// <summary>
    /// Метод, отвечающий за получение от пользователя порядкового номера файла в папке, с которым он хочет работать.
    /// </summary>
    /// <param name="currentPath">Строка, отображающая путь к текущей папке.</param>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static void SelectFile(in string currentPath, out string[] files, out int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        files = Directory.GetFiles(currentPath);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Выберите файл для работы: ");
        Console.ForegroundColor = defaultColor;
        fileNumber = 0;
        bool correctInput = false;
        do
        {
            correctInput = int.TryParse(Console.ReadLine(), out fileNumber);
            if (!correctInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный ввод. Повторите попытку.");
                Console.ForegroundColor = defaultColor;
            }
        } while (!correctInput);
        Console.Clear();
        Console.Write("Файл, который был выбран: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(files[fileNumber - 1]);
        Console.ForegroundColor = defaultColor;
    }

    /// <summary>
    /// Метод, отвечающий за чтение содержимого файла в 5 различных кодировках (включая UTF-8).
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static void ReadFile(in string[] files, in int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.WriteLine("Выберите кодировку, в которой хотите прочитать содержимое файла.");
        Console.WriteLine("Для этого напишите соответствующую цифру.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. UTF-8\n2. ASCII\n3. Unicode\n4. UTF-32");
        Console.ForegroundColor = defaultColor;
        bool correctInput = false;
        int encodingNumber;
        do
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out encodingNumber) || encodingNumber > 5 || encodingNumber < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод. Повторите попытку.");
                Console.ForegroundColor = defaultColor;
            }
            else
                correctInput = true;
        } while (!correctInput);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Содержимое файла:");
        Console.ForegroundColor = defaultColor;
        switch (encodingNumber)
        {
            case 1:
                StreamReader streamReaderVariableUTF8 = new StreamReader(files[fileNumber - 1], Encoding.UTF8, false);
                Console.WriteLine(streamReaderVariableUTF8.ReadToEnd());
                break;
            case 2:
                StreamReader streamReaderVariableASCII = new StreamReader(files[fileNumber - 1], Encoding.ASCII, false);
                Console.WriteLine(streamReaderVariableASCII.ReadToEnd());
                break;
            case 3:
                StreamReader streamReaderVariableUnicode = new StreamReader(files[fileNumber - 1], Encoding.Unicode, false);
                Console.WriteLine(streamReaderVariableUnicode.ReadToEnd());
                break;
            case 4:
                StreamReader streamReaderVariableUTF32 = new StreamReader(files[fileNumber - 1], Encoding.UTF32, false);
                Console.WriteLine(streamReaderVariableUTF32.ReadToEnd());
                break;
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Метод, отвечающий за удаление выбранного пользователем файла.
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static void DeleteFile(in string[] files, in int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        File.Delete(files[fileNumber - 1]);
        Console.Write("Удаление файла, имеющего путь ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(files[fileNumber - 1] + " ");
        Console.ForegroundColor = defaultColor;
        Console.WriteLine("успешно завершено!");
    }

    /// <summary>
    /// Метод, отвечающий за перемещение файла, выбранного пользователем.
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static void MoveFile(in string[] files, in int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.Write("Вами был выбран следующий файл для перемещения: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(files[fileNumber - 1]);
        Console.ForegroundColor = defaultColor;
        bool correctInputPath = false;
        string drive = GetDrive(in files, in fileNumber);
        GoThroughDirectoriesAndGetPath(in drive, out string inputPath);
        do
        {
            string fileName = null;
            bool nameCorrect = true;
            do
            {
                Console.Write("Введите название файла. Расширение перемещаемого файла должно совпадать с расширением нового: ");
                fileName = Console.ReadLine();
                if (string.IsNullOrEmpty(fileName) || fileName[0] == '\\'
                    || fileName[0] == ':' || fileName[0] == '/' || fileName[0] == '*'
                    || fileName[0] == '\'' || fileName[0] == '|' || fileName[0] == '?'
                    || fileName[0] == '<' || fileName[0] == '>' ||
                    Path.GetExtension(fileName) != Path.GetExtension(files[fileNumber - 1]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Имя файла или его расширение недопустимо.");
                    Console.ForegroundColor = defaultColor;
                    nameCorrect = false;
                }
                else
                    nameCorrect = true;
            } while (!nameCorrect);
            string filePath = inputPath + '\\' + fileName;
            if (!File.Exists(filePath))
            {
                File.Move(files[fileNumber - 1], filePath);
                correctInputPath = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Файл уже существует в этой директории!");
                Console.ForegroundColor = defaultColor;
                correctInputPath = false;
            }
        } while (!correctInputPath);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Файл перемещен успешно!");
        Console.ForegroundColor = defaultColor;
    }

    /// <summary>
    /// Метод, отвечающий за копирование файла, выбранного пользователем.
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    private static void CopyFile(in string[] files, in int fileNumber)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.Write("Вами был выбран следующий файл для копирования: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(files[fileNumber - 1]);
        Console.ForegroundColor = defaultColor;
        bool correctInputPath = false;
        string drive = GetDrive(in files, in fileNumber);
        GoThroughDirectoriesAndGetPath(in drive, out string inputPath);
        do
        {
            string fileName = null;
            bool nameCorrect = true;
            do
            {
                Console.Write("Введите название файла. Расширение копируемого файла должно совпадать с расширением нового: ");
                fileName = Console.ReadLine();
                if (string.IsNullOrEmpty(fileName) || fileName[0] == '\\'
                    || fileName[0] == ':' || fileName[0] == '/' || fileName[0] == '*'
                    || fileName[0] == '\'' || fileName[0] == '|' || fileName[0] == '?'
                    || fileName[0] == '<' || fileName[0] == '>' ||
                    Path.GetExtension(fileName) != Path.GetExtension(files[fileNumber - 1]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Имя файла или его расширение недопустимо.");
                    Console.ForegroundColor = defaultColor;
                    nameCorrect = false;
                }
                else
                    nameCorrect = true;
            } while (!nameCorrect);
            string filePath = inputPath + '\\' + fileName;
            if (!File.Exists(filePath))
            {
                File.Move(files[fileNumber - 1], filePath);
                correctInputPath = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Файл уже существует в этой директории!");
                Console.ForegroundColor = defaultColor;
                correctInputPath = false;
            }
        } while (!correctInputPath);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Файл скопирован успешно!");
        Console.ForegroundColor = defaultColor;
    }

    /// <summary>
    /// Определение диска, с которым работает пользователь.
    /// </summary>
    /// <param name="files">Массив файлов в директории.</param>
    /// <param name="fileNumber">Порядковый номер файла. Задается пользователем.</param>
    /// <returns>Диск, в котором ведется работа пользователя.</returns>
    private static string GetDrive(in string[] files, in int fileNumber)
    {
        string path = files[fileNumber - 1];
        string[] partsOfPath = path.Split('\\');
        return partsOfPath[0] + '\\';
    }
}
