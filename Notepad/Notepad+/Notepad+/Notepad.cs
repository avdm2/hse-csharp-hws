using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad_
{
    public partial class Notepad : Form
    {
        /// <summary>
        /// Путь файла, с которым осуществляется работа.
        /// </summary>
        private string path = null;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public Notepad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод сохранить как.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Задание фильтра расширений, в которые можно сохранить файл.
            saveFileDialog.Filter = "Текстовый файл|*.txt|Rich Text Format|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool correct = true;
                string fileName = saveFileDialog.FileName;
                try
                {
                    // Проверяем расширение. Если оно .rtf, то сохраняем файл, как .rtf (с помощью метода SaveFile). 
                    // Иначе через WriteAllLines.
                    if (CheckRtfExtension(fileName))
                        richTextBoxMain.SaveFile(fileName);
                    else
                        File.WriteAllText(fileName, richTextBoxMain.Text);
                }
                catch (Exception ex)
                {
                    correct = false;
                    MessageBox.Show($"{ex.Message}", "Ошибка!");
                }
                if (correct)
                {
                    MessageBox.Show("Файл сохранен успешно!", "Сохранено.");
                    // Смена заголовка формы. Отныне она содержит полный путь до открытого файла.
                    ActiveForm.Text = $"{fileName} - Notepad+";
                }
                path = fileName;
            }
        }

        /// <summary>
        /// Метод сохранения файла.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если сохранение происходит при пустом пути к файлу, то вызывается метод "Сохранить как", 
            // поскольку метод "Сохранить" подразумевает перезапись имеющегося на диске файла.
            if (path == null)
                СохранитьКакToolStripMenuItem_Click(sender, e);
            else
            {
                bool correct = true;
                // Аналогично, как и с "Сохранить как".
                try
                {
                    if (CheckRtfExtension(path))
                        richTextBoxMain.SaveFile(path);
                    else
                        File.WriteAllText(path, richTextBoxMain.Text);
                }
                catch (Exception ex)
                {
                    correct = false;
                    MessageBox.Show($"{ex.Message}", "Ошибка!");
                }
                if (correct)
                {
                    MessageBox.Show("Файл сохранен успешно!", "Сохранено.");
                    // Смена заголовка формы. Отныне она содержит полный путь до открытого файла.
                    ActiveForm.Text = $"{path} - Notepad+";
                }
            }
        }

        /// <summary>
        /// Метод открытия файла.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool correct = true;
                string fileName = openFileDialog.FileName;
                try
                {
                    // По аналогии с предыдущими двумя методами, однако сейчас требуется не сохранить, а открыть файл.
                    // Для этого используем либо метод LoadFile (если открытый файл обладает расширением .rtf), либо 
                    // метод ReadAllText (иначе).
                    if (CheckRtfExtension(fileName))
                        richTextBoxMain.LoadFile(fileName);
                    else
                        richTextBoxMain.Text = File.ReadAllText(fileName);
                }
                catch (Exception ex)
                {
                    correct = false;
                    MessageBox.Show($"{ex.Message}", "Ошибка!");
                }
                if (correct)
                {
                    MessageBox.Show("Файл открыт успешно!", "Открыто.");
                    ActiveForm.Text = $"{fileName} - Notepad+";
                }
                path = fileName;
            }
        }

        /// <summary>
        /// Задание красной темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КрасныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
            richTextBoxMain.BackColor = Color.Red;
        }

        /// <summary>
        /// Задание синей темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void СинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
            richTextBoxMain.BackColor = Color.Blue;
        }

        /// <summary>
        /// Задание зеленой темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЗеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
            richTextBoxMain.BackColor = Color.Green;
        }

        /// <summary>
        /// Задание желтой темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЖелтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.BackColor = Color.Yellow;
            richTextBoxMain.ForeColor = Color.Black;
        }

        /// <summary>
        /// Задание фиолетовой темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ФиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
            richTextBoxMain.BackColor = Color.Purple;
        }

        /// <summary>
        /// Задание белой (стандартной) темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта (на стандартный) для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void БелыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.Black;
            richTextBoxMain.BackColor = Color.White;
        }

        /// <summary>
        /// Задание черной темы для заднего фона richTextBox'a. Вместе с этим применяется и автоматическая 
        /// смена цвета шрифта для более удобного чтения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЧерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
            richTextBoxMain.BackColor = Color.Black;
        }

        /// <summary>
        /// Вызов окна (fontDialog) для выбора шрифта и его размера.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВыборШрифтаИРазмераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBoxMain.Font = fontDialog.Font;
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Жирный" через верхнее меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЖирныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Bold | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Курсив" через верхнее меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КурсивToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Italic | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Подчеркнутый" через верхнее меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ПодчеркнутыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Underline | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Зачеркнутый" через верхнее меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЗачеркнутыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Strikeout | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "По умолчанию" через верхнее меню приложения.
        /// После применения такого стиля все ранее наложенные на текст стили будут отменены.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Метод вызова контекстного меню при нажатии правой клавиши мыши.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBoxMain.ContextMenuStrip = contextMenuStrip;
            }
        }

        /// <summary>
        /// Метод выбора всего текста в richTextBox'е путем нажатия на соответствующий пункт
        /// контекстного меню, вызываемого нажатием правой кнопкой мыши.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВыбратьВесьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectAll();
        }

        /// <summary>
        /// Метод вырезания выделенного фрагмента текста в richTextBox'е путем нажатия на соответствующий пункт
        /// контекстного меню, вызываемого нажатием правой кнопкой мыши.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Cut();
        }

        /// <summary>
        /// Метод копирования выделенного фрагмента текста в richTextBox'е путем нажатия на соответствующий пункт
        /// контекстного меню, вызываемого нажатием правой кнопкой мыши.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Copy();
        }

        /// <summary>
        /// Метод вставки фрагмента текста в richTextBox'е из буфера путем нажатия на соответствующий пункт
        /// контекстного меню, вызываемого нажатием правой кнопкой мыши.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
                MessageBox.Show("К сожалению, можно вставлять только текст.", "Ошибка!");
            else
                richTextBoxMain.Paste();
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Жирный" через контекстное меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЖирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Bold | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Курсив" через контекстное меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КурсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Italic | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Подчеркнутый" через контекстное меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ПодчеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Underline | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "Зачеркнутый" через контекстное меню приложения.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЗачеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Strikeout | richTextBoxMain.SelectionFont.Style);
        }

        /// <summary>
        /// Задание выделенному / последующе написанному тексту стиля "По умолчанию" через контекстное меню приложения.
        /// После применения такого стиля все ранее наложенные на текст стили будут отменены.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ПоУмолчаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectionFont = new Font(richTextBoxMain.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Задание белого цвета для шрифта текста в richTextBox'e.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void БелыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.White;
        }

        /// <summary>
        /// Задание черного (стандартного) цвета для шрифта текста в richTextBox'e.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЧерныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.Black;
        }

        /// <summary>
        /// Задание красного цвета для шрифта текста в richTextBox'e.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КрасныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.Red;
        }

        /// <summary>
        /// Задание зеленого цвета для шрифта текста в richTextBox'e.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЗеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.Green;
        }

        /// <summary>
        /// Задание желтого цвета для шрифта текста в richTextBox'e.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ЖелтыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.ForeColor = Color.Yellow;
        }

        /// <summary>
        /// Метод выбора всего текста в richTextBox'е путем нажатия на соответствующий пункт
        /// меню "Формат".
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВыделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectAll();
        }

        /// <summary>
        /// Метод вырезания выделенного фрагмента текста в richTextBox'е путем нажатия на соответствующий пункт
        /// меню "Формат".
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Cut();
        }

        /// <summary>
        /// Метод копирования выделенного фрагмента текста в richTextBox'е путем нажатия на соответствующий пункт
        /// меню "Формат".
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void КопироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Copy();
        }

        /// <summary>
        /// Метод вставки фрагмента текста в richTextBox'е из буфера путем нажатия на соответствующий пункт
        /// меню "Формат".
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void ВставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Так как приложение не подразумевает вставку изображений в richTextBox, в следующей
            // строке идет проверка на содержимое буфера обмена, а именно на наличие в нем изображения.
            if (Clipboard.ContainsImage())
                MessageBox.Show("К сожалению, можно вставлять только текст.", "Ошибка!");
            else
                richTextBoxMain.Paste();
        }

        /// <summary>
        /// Метод для запрета вставки изображений.
        /// </summary>
        /// <param name="sender">Издатель события.</param>
        /// <param name="e">Информация о событии.</param>
        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверка нажатых клавиш.
            if (e.Control && e.KeyCode == Keys.V)
                // Проверка на то, содержит ли буфер обмена картинку.
                if (Clipboard.ContainsImage())
                {
                    e.Handled = true;
                    MessageBox.Show("К сожалению, можно вставлять только текст.", "Ошибка!");
                }
        }

        /// <summary>
        /// Переопределение метода закрытия формы с целью предоставления пользователю возможности 
        /// сохранить или не сохранять внесенные изменения (если таковые имеются) в документ.
        /// </summary>
        /// <param name="e">Информация о событии.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if ((path == null && richTextBoxMain.Text.Length != 0) ||
                (path != null && CheckRtfExtension(path) && !RtfEquals(path) && richTextBoxMain.Modified) ||
                (path != null && !CheckRtfExtension(path) && File.ReadAllText(path) != richTextBoxMain.Text))
            {
                DialogResult pressedExitButton = MessageBox.Show($"Несохраненный документ. Сохранить?", "Выход", MessageBoxButtons.YesNoCancel);
                if (pressedExitButton == DialogResult.Cancel)
                    e.Cancel = true;
                if (pressedExitButton == DialogResult.Yes)
                    IfPressedExitButtonIsYes(e);
                if (pressedExitButton == DialogResult.No)
                    return;
            }
            else
                return;
        }

        /// <summary>
        /// Метод, вызываемый в случае нажатия кнопки "Да" после закрытия редактора, если остались
        /// несохраненные изменения в редактируемом документе.
        /// </summary>
        /// <param name="e">Информация о событии.</param>
        private void IfPressedExitButtonIsYes(FormClosingEventArgs e)
        {
            if (path == null)
            {
                // Метод "Сохранить как", так как "path" == null, а "Сохранить" подразумевается
                // именно для противоположенного случая.
                // Задание фильтра расширений, в которые можно сохранить файл.
                saveFileDialog.Filter = "Текстовый файл|*.txt|Rich Text Format|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    e.Cancel = true;
                else
                {
                    bool correct = true;
                    string fileName = saveFileDialog.FileName;
                    try
                    {
                        // Проверяем расширение. Если оно .rtf, то сохраняем файл, как .rtf (с помощью метода SaveFile). 
                        // Иначе через WriteAllLines.
                        if (CheckRtfExtension(fileName))
                            richTextBoxMain.SaveFile(fileName);
                        else
                            File.WriteAllText(fileName, richTextBoxMain.Text);
                    }
                    catch (Exception ex)
                    {
                        correct = false;
                        MessageBox.Show($"{ex.Message}", "Ошибка!");
                    }
                    if (correct)
                    {
                        MessageBox.Show("Файл сохранен успешно!", "Сохранено.");
                        // Смена заголовка формы. Отныне она содержит полный путь до открытого файла.
                        ActiveForm.Text = $"{fileName} - Notepad+";
                    }
                    path = fileName;
                }
            }
            // Метод "Сохранить", поскольку "path" != null, а "Сохранить как" подразумевается
            // именно для противоположенного случая.
            else
            {
                bool correct = true;
                try
                {
                    // Аналогично, как и с "Сохранить как".
                    if (CheckRtfExtension(path))
                        richTextBoxMain.SaveFile(path);
                    else
                        File.WriteAllText(path, richTextBoxMain.Text);
                }
                catch (Exception ex)
                {
                    correct = false;
                    MessageBox.Show($"{ex.Message}", "Ошибка!");
                }
                if (correct)
                {
                    MessageBox.Show("Файл сохранен успешно!", "Сохранено.");
                    // Смена заголовка формы. Отныне она содержит полный путь до открытого файла.
                    ActiveForm.Text = $"{path} - Notepad+";
                }
            }
        }

        /// <summary>
        /// Метод для проверки расширения (.rtf или не .rtf) файла.
        /// </summary>
        /// <param name="fileName">Полный путь до файла, включая его расширение.</param>
        /// <returns>True, если файл с расширением .rtf, иначе False.</returns>
        private static bool CheckRtfExtension(string fileName) =>
            fileName[^1] == 'f' && fileName[^2] == 't' &&
            fileName[^3] == 'r' && fileName[^4] == '.';

        /// <summary>
        /// Проверка на равенство имеющегося на диске открытого файла с расширением .rtf с
        /// содержимым richTextBox'a.
        /// </summary>
        /// <param name="path">Полный путь до открытого файла.</param>
        /// <returns>True, если файл на диске равен содержимому richTextBox'а, иначе False.</returns>
        private bool RtfEquals(string path)
        {
            // Создание нового richTextBox'а, куда будет загружено содержимое файла "path" на диске.
            RichTextBox rtbForCheck = new RichTextBox();
            bool correct = true;
            try
            {
                rtbForCheck.LoadFile(path);
            }
            catch (Exception ex)
            {
                correct = false;
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
            if (correct)
            {
                // Проверка на равенство шрифтов и текстов в основном richTextBox'е и созданном в методе.
                if (rtbForCheck.Text == richTextBoxMain.Text && rtbForCheck.Font == richTextBoxMain.Font)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
