-----------------Консольное приложение "Файловый менеждер"-----------------

Функции приложения:
1. Просмотр списка дисков компьютера и выбор диска.
2. Переход в другую директорию (выбор папки).
3. Просмотр списка файлов в директории.
4. Вывод содержимого текстового файла в консоль в кодировке UTF-8.
5. Вывод содержимого текстового файла в консоль в следующих предложенных 
кодировках: ASCII, Unicode, UTF-32.
6. Копирование файла в выбранную пользователем директорию.
7. Перемещение файла в выбранную пользователем директорию.
8. Удаление файла.


Примечание:
1. Файл, содержимое которого будет выведено пользователю через вызов соответствующего
метода, может быть как расширения .txt, так и любого другого. Как следствие, считывание
всех строк файла и последующий их вывод на экран может занять достаточно продолжительное
количество времени (если, например, попытаться прочитать .exe).

2. Пожалуйста, обратите внимание на то, что на консоль выводятся как файлы, так и другие
директории, находящиеся в этой папке. Порядок действий будет прописан
в консоле, однако имейте в виду: прежде, чем выбрать файл, необходимо выбрать
ДИРЕКТОРИЮ путем ввода в консоль соответствующего ей порядкового номера, либо
прописав "Done", если выбор папки окончателен.

3. Наиболее корректно программа работает на системах OS Windows.