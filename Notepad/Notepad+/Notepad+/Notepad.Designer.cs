
namespace Notepad_
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборШрифтаИРазмераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборСтиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.подчеркнутыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зачеркнутыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиолетовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьВесьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьФорматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчеркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зачеркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(800, 613);
            this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1_KeyDown);
            this.richTextBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RichTextBox1_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem,
            this.вырезатьToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.ВыделитьВсеToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.ВырезатьToolStripMenuItem1_Click);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.КопироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.ВставитьToolStripMenuItem1_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборШрифтаИРазмераToolStripMenuItem,
            this.выборСтиляToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // выборШрифтаИРазмераToolStripMenuItem
            // 
            this.выборШрифтаИРазмераToolStripMenuItem.Name = "выборШрифтаИРазмераToolStripMenuItem";
            this.выборШрифтаИРазмераToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.выборШрифтаИРазмераToolStripMenuItem.Text = "Выбор шрифта и размера";
            this.выборШрифтаИРазмераToolStripMenuItem.Click += new System.EventHandler(this.ВыборШрифтаИРазмераToolStripMenuItem_Click);
            // 
            // выборСтиляToolStripMenuItem
            // 
            this.выборСтиляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жирныйToolStripMenuItem1,
            this.курсивToolStripMenuItem1,
            this.подчеркнутыйToolStripMenuItem1,
            this.зачеркнутыйToolStripMenuItem1,
            this.поУмолчаниюToolStripMenuItem});
            this.выборСтиляToolStripMenuItem.Name = "выборСтиляToolStripMenuItem";
            this.выборСтиляToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.выборСтиляToolStripMenuItem.Text = "Выбор стиля";
            // 
            // жирныйToolStripMenuItem1
            // 
            this.жирныйToolStripMenuItem1.Name = "жирныйToolStripMenuItem1";
            this.жирныйToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.жирныйToolStripMenuItem1.Text = "Жирный";
            this.жирныйToolStripMenuItem1.Click += new System.EventHandler(this.ЖирныйToolStripMenuItem1_Click);
            // 
            // курсивToolStripMenuItem1
            // 
            this.курсивToolStripMenuItem1.Name = "курсивToolStripMenuItem1";
            this.курсивToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.курсивToolStripMenuItem1.Text = "Курсив";
            this.курсивToolStripMenuItem1.Click += new System.EventHandler(this.КурсивToolStripMenuItem1_Click);
            // 
            // подчеркнутыйToolStripMenuItem1
            // 
            this.подчеркнутыйToolStripMenuItem1.Name = "подчеркнутыйToolStripMenuItem1";
            this.подчеркнутыйToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.подчеркнутыйToolStripMenuItem1.Text = "Подчеркнутый";
            this.подчеркнутыйToolStripMenuItem1.Click += new System.EventHandler(this.ПодчеркнутыйToolStripMenuItem1_Click);
            // 
            // зачеркнутыйToolStripMenuItem1
            // 
            this.зачеркнутыйToolStripMenuItem1.Name = "зачеркнутыйToolStripMenuItem1";
            this.зачеркнутыйToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.зачеркнутыйToolStripMenuItem1.Text = "Зачеркнутый";
            this.зачеркнутыйToolStripMenuItem1.Click += new System.EventHandler(this.ЗачеркнутыйToolStripMenuItem1_Click);
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            this.поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            this.поУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.поУмолчаниюToolStripMenuItem.Text = "По умолчанию";
            this.поУмолчаниюToolStripMenuItem.Click += new System.EventHandler(this.ПоУмолчаниюToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиФонаToolStripMenuItem,
            this.настройкаЦветаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиФонаToolStripMenuItem
            // 
            this.настройкиФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.желтыйToolStripMenuItem,
            this.фиолетовыйToolStripMenuItem,
            this.белыйToolStripMenuItem,
            this.черныйToolStripMenuItem});
            this.настройкиФонаToolStripMenuItem.Name = "настройкиФонаToolStripMenuItem";
            this.настройкиФонаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.настройкиФонаToolStripMenuItem.Text = "Настройки фона";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.КрасныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.СинийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.ЗеленыйToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            this.желтыйToolStripMenuItem.Click += new System.EventHandler(this.ЖелтыйToolStripMenuItem_Click);
            // 
            // фиолетовыйToolStripMenuItem
            // 
            this.фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            this.фиолетовыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            this.фиолетовыйToolStripMenuItem.Click += new System.EventHandler(this.ФиолетовыйToolStripMenuItem_Click);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.белыйToolStripMenuItem.Text = "Белый";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.БелыйToolStripMenuItem_Click);
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.черныйToolStripMenuItem.Text = "Черный";
            this.черныйToolStripMenuItem.Click += new System.EventHandler(this.ЧерныйToolStripMenuItem_Click);
            // 
            // настройкаЦветаToolStripMenuItem
            // 
            this.настройкаЦветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.белыйToolStripMenuItem1,
            this.черныйToolStripMenuItem1,
            this.красныйToolStripMenuItem1,
            this.зеленыйToolStripMenuItem1,
            this.желтыйToolStripMenuItem1});
            this.настройкаЦветаToolStripMenuItem.Name = "настройкаЦветаToolStripMenuItem";
            this.настройкаЦветаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.настройкаЦветаToolStripMenuItem.Text = "Настройка цвета шрифта";
            // 
            // белыйToolStripMenuItem1
            // 
            this.белыйToolStripMenuItem1.Name = "белыйToolStripMenuItem1";
            this.белыйToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.белыйToolStripMenuItem1.Text = "Белый";
            this.белыйToolStripMenuItem1.Click += new System.EventHandler(this.БелыйToolStripMenuItem1_Click);
            // 
            // черныйToolStripMenuItem1
            // 
            this.черныйToolStripMenuItem1.Name = "черныйToolStripMenuItem1";
            this.черныйToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.черныйToolStripMenuItem1.Text = "Черный";
            this.черныйToolStripMenuItem1.Click += new System.EventHandler(this.ЧерныйToolStripMenuItem1_Click);
            // 
            // красныйToolStripMenuItem1
            // 
            this.красныйToolStripMenuItem1.Name = "красныйToolStripMenuItem1";
            this.красныйToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.красныйToolStripMenuItem1.Text = "Красный";
            this.красныйToolStripMenuItem1.Click += new System.EventHandler(this.КрасныйToolStripMenuItem1_Click);
            // 
            // зеленыйToolStripMenuItem1
            // 
            this.зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            this.зеленыйToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.зеленыйToolStripMenuItem1.Text = "Зеленый";
            this.зеленыйToolStripMenuItem1.Click += new System.EventHandler(this.ЗеленыйToolStripMenuItem1_Click);
            // 
            // желтыйToolStripMenuItem1
            // 
            this.желтыйToolStripMenuItem1.Name = "желтыйToolStripMenuItem1";
            this.желтыйToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.желтыйToolStripMenuItem1.Text = "Желтый";
            this.желтыйToolStripMenuItem1.Click += new System.EventHandler(this.ЖелтыйToolStripMenuItem1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьВесьТекстToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.задатьФорматToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(157, 114);
            // 
            // выбратьВесьТекстToolStripMenuItem
            // 
            this.выбратьВесьТекстToolStripMenuItem.Name = "выбратьВесьТекстToolStripMenuItem";
            this.выбратьВесьТекстToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.выбратьВесьТекстToolStripMenuItem.Text = "Выделить все";
            this.выбратьВесьТекстToolStripMenuItem.Click += new System.EventHandler(this.ВыбратьВесьТекстToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ВырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ВставитьToolStripMenuItem_Click);
            // 
            // задатьФорматToolStripMenuItem
            // 
            this.задатьФорматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жирныйToolStripMenuItem,
            this.курсивToolStripMenuItem,
            this.подчеркнутыйToolStripMenuItem,
            this.зачеркнутыйToolStripMenuItem,
            this.поУмолчаниюToolStripMenuItem1});
            this.задатьФорматToolStripMenuItem.Name = "задатьФорматToolStripMenuItem";
            this.задатьФорматToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.задатьФорматToolStripMenuItem.Text = "Задать формат";
            // 
            // жирныйToolStripMenuItem
            // 
            this.жирныйToolStripMenuItem.Name = "жирныйToolStripMenuItem";
            this.жирныйToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.жирныйToolStripMenuItem.Text = "Жирный";
            this.жирныйToolStripMenuItem.Click += new System.EventHandler(this.ЖирныйToolStripMenuItem_Click);
            // 
            // курсивToolStripMenuItem
            // 
            this.курсивToolStripMenuItem.Name = "курсивToolStripMenuItem";
            this.курсивToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.курсивToolStripMenuItem.Text = "Курсив";
            this.курсивToolStripMenuItem.Click += new System.EventHandler(this.КурсивToolStripMenuItem_Click);
            // 
            // подчеркнутыйToolStripMenuItem
            // 
            this.подчеркнутыйToolStripMenuItem.Name = "подчеркнутыйToolStripMenuItem";
            this.подчеркнутыйToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.подчеркнутыйToolStripMenuItem.Text = "Подчеркнутый";
            this.подчеркнутыйToolStripMenuItem.Click += new System.EventHandler(this.ПодчеркнутыйToolStripMenuItem_Click);
            // 
            // зачеркнутыйToolStripMenuItem
            // 
            this.зачеркнутыйToolStripMenuItem.Name = "зачеркнутыйToolStripMenuItem";
            this.зачеркнутыйToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.зачеркнутыйToolStripMenuItem.Text = "Зачеркнутый";
            this.зачеркнутыйToolStripMenuItem.Click += new System.EventHandler(this.ЗачеркнутыйToolStripMenuItem_Click);
            // 
            // поУмолчаниюToolStripMenuItem1
            // 
            this.поУмолчаниюToolStripMenuItem1.Name = "поУмолчаниюToolStripMenuItem1";
            this.поУмолчаниюToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.поУмолчаниюToolStripMenuItem1.Text = "По умолчанию";
            this.поУмолчаниюToolStripMenuItem1.Click += new System.EventHandler(this.ПоУмолчаниюToolStripMenuItem1_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Notepad";
            this.Text = "Notepad+";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиолетовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборШрифтаИРазмераToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem выборСтиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem курсивToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem подчеркнутыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зачеркнутыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem выбратьВесьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьФорматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчеркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зачеркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкаЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
    }
}

