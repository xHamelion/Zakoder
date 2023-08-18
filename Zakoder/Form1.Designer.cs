
namespace Zakoder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTB_Vvod = new System.Windows.Forms.RichTextBox();
            this.RTB_Rezult = new System.Windows.Forms.RichTextBox();
            this.L_Vhodn_Dan = new System.Windows.Forms.Label();
            this.L_rezult = new System.Windows.Forms.Label();
            this.LB_Vibor = new System.Windows.Forms.ListBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Vibor = new System.Windows.Forms.ComboBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Povtor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Setings = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Import = new System.Windows.Forms.Button();
            this.BTN_Export = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CeckB_Prov_Instr = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CeckB_Save_Instr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RTB_Instr = new System.Windows.Forms.RichTextBox();
            this.BTN_Close_Seting = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Vvod
            // 
            this.RTB_Vvod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTB_Vvod.Location = new System.Drawing.Point(13, 68);
            this.RTB_Vvod.Name = "RTB_Vvod";
            this.RTB_Vvod.Size = new System.Drawing.Size(519, 172);
            this.RTB_Vvod.TabIndex = 0;
            this.RTB_Vvod.Text = "";
            // 
            // RTB_Rezult
            // 
            this.RTB_Rezult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTB_Rezult.Location = new System.Drawing.Point(13, 334);
            this.RTB_Rezult.Name = "RTB_Rezult";
            this.RTB_Rezult.ReadOnly = true;
            this.RTB_Rezult.Size = new System.Drawing.Size(519, 172);
            this.RTB_Rezult.TabIndex = 1;
            this.RTB_Rezult.Text = "";
            // 
            // L_Vhodn_Dan
            // 
            this.L_Vhodn_Dan.AutoSize = true;
            this.L_Vhodn_Dan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Vhodn_Dan.Location = new System.Drawing.Point(9, 42);
            this.L_Vhodn_Dan.Name = "L_Vhodn_Dan";
            this.L_Vhodn_Dan.Size = new System.Drawing.Size(144, 21);
            this.L_Vhodn_Dan.TabIndex = 2;
            this.L_Vhodn_Dan.Text = "Входные данные";
            // 
            // L_rezult
            // 
            this.L_rezult.AutoSize = true;
            this.L_rezult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_rezult.Location = new System.Drawing.Point(9, 308);
            this.L_rezult.Name = "L_rezult";
            this.L_rezult.Size = new System.Drawing.Size(86, 21);
            this.L_rezult.TabIndex = 3;
            this.L_rezult.Text = "Результат";
            // 
            // LB_Vibor
            // 
            this.LB_Vibor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Vibor.FormattingEnabled = true;
            this.LB_Vibor.ItemHeight = 21;
            this.LB_Vibor.Items.AddRange(new object[] {
            "Английскиий язык в Цифры",
            "Шифр с Английского языка и Цифр на Русский",
            "--------------------------------------------------------------------------------",
            "Русский язык в Цифры",
            "--------------------------------------------------------------------------------",
            "Шифр Случайных Значений",
            "--------------------------------------------------------------------------------",
            "Шифр с Русского языка и Цифр на Английский - Final!"});
            this.LB_Vibor.Location = new System.Drawing.Point(548, 68);
            this.LB_Vibor.Name = "LB_Vibor";
            this.LB_Vibor.Size = new System.Drawing.Size(454, 529);
            this.LB_Vibor.TabIndex = 4;
            this.LB_Vibor.SelectedIndexChanged += new System.EventHandler(this.LB_Vibor_SelectedIndexChanged);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Start.Location = new System.Drawing.Point(136, 270);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(117, 31);
            this.BTN_Start.TabIndex = 5;
            this.BTN_Start.Text = "Старт";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(544, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип шифрования";
            // 
            // CB_Vibor
            // 
            this.CB_Vibor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Vibor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_Vibor.FormattingEnabled = true;
            this.CB_Vibor.Items.AddRange(new object[] {
            "Зашифровка",
            "Дешифровка"});
            this.CB_Vibor.Location = new System.Drawing.Point(259, 270);
            this.CB_Vibor.Name = "CB_Vibor";
            this.CB_Vibor.Size = new System.Drawing.Size(129, 29);
            this.CB_Vibor.TabIndex = 7;
            this.CB_Vibor.TextChanged += new System.EventHandler(this.CB_Vibor_TextChanged);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Clear.Location = new System.Drawing.Point(13, 270);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(117, 31);
            this.BTN_Clear.TabIndex = 8;
            this.BTN_Clear.Text = "Очистить";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Povtor
            // 
            this.BTN_Povtor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Povtor.Location = new System.Drawing.Point(394, 247);
            this.BTN_Povtor.Name = "BTN_Povtor";
            this.BTN_Povtor.Size = new System.Drawing.Size(138, 84);
            this.BTN_Povtor.TabIndex = 9;
            this.BTN_Povtor.Text = "Продолжить шифрование";
            this.BTN_Povtor.UseVisualStyleBackColor = true;
            this.BTN_Povtor.Click += new System.EventHandler(this.BTN_Povtor_Shifr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.TSMI_Setings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // TSMI_Setings
            // 
            this.TSMI_Setings.Name = "TSMI_Setings";
            this.TSMI_Setings.Size = new System.Drawing.Size(94, 23);
            this.TSMI_Setings.Text = "Настройки";
            this.TSMI_Setings.Click += new System.EventHandler(this.TSMI_Setings_Click);
            // 
            // BTN_Import
            // 
            this.BTN_Import.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Import.Location = new System.Drawing.Point(159, 30);
            this.BTN_Import.Name = "BTN_Import";
            this.BTN_Import.Size = new System.Drawing.Size(373, 31);
            this.BTN_Import.TabIndex = 11;
            this.BTN_Import.Text = "Импорт";
            this.BTN_Import.UseVisualStyleBackColor = true;
            this.BTN_Import.Click += new System.EventHandler(this.BTN_Import_Click);
            // 
            // BTN_Export
            // 
            this.BTN_Export.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Export.Location = new System.Drawing.Point(12, 512);
            this.BTN_Export.Name = "BTN_Export";
            this.BTN_Export.Size = new System.Drawing.Size(520, 31);
            this.BTN_Export.TabIndex = 12;
            this.BTN_Export.Text = "Экспорт";
            this.BTN_Export.UseVisualStyleBackColor = true;
            this.BTN_Export.Click += new System.EventHandler(this.BTN_Export_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CeckB_Prov_Instr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CeckB_Save_Instr);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(1060, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 475);
            this.panel1.TabIndex = 13;
            // 
            // CeckB_Prov_Instr
            // 
            this.CeckB_Prov_Instr.AutoSize = true;
            this.CeckB_Prov_Instr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CeckB_Prov_Instr.Location = new System.Drawing.Point(23, 99);
            this.CeckB_Prov_Instr.Name = "CeckB_Prov_Instr";
            this.CeckB_Prov_Instr.Size = new System.Drawing.Size(295, 25);
            this.CeckB_Prov_Instr.TabIndex = 16;
            this.CeckB_Prov_Instr.Text = "Проверять файлы на инструкции";
            this.CeckB_Prov_Instr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Шифравка и дешивровка";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1258, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Декод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CeckB_Save_Instr
            // 
            this.CeckB_Save_Instr.AutoSize = true;
            this.CeckB_Save_Instr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CeckB_Save_Instr.Location = new System.Drawing.Point(23, 56);
            this.CeckB_Save_Instr.Name = "CeckB_Save_Instr";
            this.CeckB_Save_Instr.Size = new System.Drawing.Size(326, 25);
            this.CeckB_Save_Instr.TabIndex = 0;
            this.CeckB_Save_Instr.Text = "Сохранять инструкцию дешифровки";
            this.CeckB_Save_Instr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1056, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Настройки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 20);
            this.textBox1.TabIndex = 15;
            // 
            // RTB_Instr
            // 
            this.RTB_Instr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTB_Instr.Location = new System.Drawing.Point(415, 346);
            this.RTB_Instr.Name = "RTB_Instr";
            this.RTB_Instr.ReadOnly = true;
            this.RTB_Instr.Size = new System.Drawing.Size(127, 172);
            this.RTB_Instr.TabIndex = 17;
            this.RTB_Instr.Text = "";
            // 
            // BTN_Close_Seting
            // 
            this.BTN_Close_Seting.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Close_Seting.Location = new System.Drawing.Point(1332, 30);
            this.BTN_Close_Seting.Name = "BTN_Close_Seting";
            this.BTN_Close_Seting.Size = new System.Drawing.Size(93, 31);
            this.BTN_Close_Seting.TabIndex = 17;
            this.BTN_Close_Seting.Text = "Закрыть";
            this.BTN_Close_Seting.UseVisualStyleBackColor = true;
            this.BTN_Close_Seting.Click += new System.EventHandler(this.BTN_Close_Seting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1495, 571);
            this.Controls.Add(this.BTN_Close_Seting);
            this.Controls.Add(this.RTB_Instr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_Export);
            this.Controls.Add(this.BTN_Import);
            this.Controls.Add(this.BTN_Povtor);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.CB_Vibor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LB_Vibor);
            this.Controls.Add(this.L_rezult);
            this.Controls.Add(this.L_Vhodn_Dan);
            this.Controls.Add(this.RTB_Rezult);
            this.Controls.Add(this.RTB_Vvod);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xHamelion - шифратор текста";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Vvod;
        private System.Windows.Forms.RichTextBox RTB_Rezult;
        private System.Windows.Forms.Label L_Vhodn_Dan;
        private System.Windows.Forms.Label L_rezult;
        private System.Windows.Forms.ListBox LB_Vibor;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Vibor;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_Povtor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Import;
        private System.Windows.Forms.Button BTN_Export;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CeckB_Save_Instr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CeckB_Prov_Instr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RTB_Instr;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Setings;
        private System.Windows.Forms.Button BTN_Close_Seting;
    }
}

