namespace Laba3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            очиститьВсеПоляToolStripMenuItem = new ToolStripMenuItem();
            pLabel = new Label();
            qLabel = new Label();
            bLabel = new Label();
            groupBox = new GroupBox();
            decryptRadioButton = new RadioButton();
            encryptRadioButton = new RadioButton();
            pTextBox = new TextBox();
            bTextBox = new TextBox();
            qTextBox = new TextBox();
            plainTextBox = new TextBox();
            resultTextBox = new TextBox();
            plainLabel = new Label();
            resultLabel = new Label();
            openButton = new Button();
            saveButton = new Button();
            executeButton = new Button();
            plainRadioButton = new RadioButton();
            cipherRadioButton = new RadioButton();
            plainPanel = new Panel();
            plainResRadioButton = new RadioButton();
            cipherResRadioButton = new RadioButton();
            resultPanel = new Panel();
            plainOpenFileDialog = new OpenFileDialog();
            cipherOpenFileDialog = new OpenFileDialog();
            plainSaveFileDialog = new SaveFileDialog();
            cipherSaveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            groupBox.SuspendLayout();
            plainPanel.SuspendLayout();
            resultPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, очиститьВсеПоляToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(841, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(305, 34);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += OpenFile;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьКакToolStripMenuItem.Size = new Size(305, 34);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += SaveFile;
            // 
            // очиститьВсеПоляToolStripMenuItem
            // 
            очиститьВсеПоляToolStripMenuItem.Name = "очиститьВсеПоляToolStripMenuItem";
            очиститьВсеПоляToolStripMenuItem.Size = new Size(179, 29);
            очиститьВсеПоляToolStripMenuItem.Text = "Очистить все поля";
            очиститьВсеПоляToolStripMenuItem.Click += ClearFields;
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pLabel.Location = new Point(26, 54);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(152, 33);
            pLabel.TabIndex = 1;
            pLabel.Text = "Значение p:";
            // 
            // qLabel
            // 
            qLabel.AutoSize = true;
            qLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            qLabel.Location = new Point(26, 108);
            qLabel.Name = "qLabel";
            qLabel.Size = new Size(152, 33);
            qLabel.TabIndex = 2;
            qLabel.Text = "Значение q:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bLabel.Location = new Point(26, 162);
            bLabel.Name = "bLabel";
            bLabel.Size = new Size(152, 33);
            bLabel.TabIndex = 3;
            bLabel.Text = "Значение b:";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(decryptRadioButton);
            groupBox.Controls.Add(encryptRadioButton);
            groupBox.Controls.Add(pTextBox);
            groupBox.Controls.Add(bTextBox);
            groupBox.Controls.Add(qTextBox);
            groupBox.Controls.Add(bLabel);
            groupBox.Controls.Add(qLabel);
            groupBox.Controls.Add(pLabel);
            groupBox.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox.Location = new Point(12, 36);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(817, 307);
            groupBox.TabIndex = 4;
            groupBox.TabStop = false;
            groupBox.Text = "Настройки";
            // 
            // decryptRadioButton
            // 
            decryptRadioButton.AutoSize = true;
            decryptRadioButton.Location = new Point(427, 235);
            decryptRadioButton.Name = "decryptRadioButton";
            decryptRadioButton.Size = new Size(277, 45);
            decryptRadioButton.TabIndex = 5;
            decryptRadioButton.Text = "Дешифрование";
            decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptRadioButton
            // 
            encryptRadioButton.AutoSize = true;
            encryptRadioButton.Checked = true;
            encryptRadioButton.Location = new Point(129, 235);
            encryptRadioButton.Name = "encryptRadioButton";
            encryptRadioButton.Size = new Size(244, 45);
            encryptRadioButton.TabIndex = 4;
            encryptRadioButton.TabStop = true;
            encryptRadioButton.Text = "Шифрование";
            encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // pTextBox
            // 
            pTextBox.BorderStyle = BorderStyle.FixedSingle;
            pTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pTextBox.Location = new Point(184, 52);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(616, 35);
            pTextBox.TabIndex = 1;
            // 
            // bTextBox
            // 
            bTextBox.BorderStyle = BorderStyle.FixedSingle;
            bTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bTextBox.Location = new Point(184, 160);
            bTextBox.Name = "bTextBox";
            bTextBox.Size = new Size(616, 35);
            bTextBox.TabIndex = 3;
            // 
            // qTextBox
            // 
            qTextBox.BorderStyle = BorderStyle.FixedSingle;
            qTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            qTextBox.Location = new Point(184, 106);
            qTextBox.Name = "qTextBox";
            qTextBox.Size = new Size(616, 35);
            qTextBox.TabIndex = 2;
            // 
            // plainTextBox
            // 
            plainTextBox.BorderStyle = BorderStyle.FixedSingle;
            plainTextBox.Location = new Point(50, 398);
            plainTextBox.Multiline = true;
            plainTextBox.Name = "plainTextBox";
            plainTextBox.ReadOnly = true;
            plainTextBox.ScrollBars = ScrollBars.Vertical;
            plainTextBox.Size = new Size(347, 273);
            plainTextBox.TabIndex = 5;
            // 
            // resultTextBox
            // 
            resultTextBox.BorderStyle = BorderStyle.FixedSingle;
            resultTextBox.Location = new Point(444, 398);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(347, 273);
            resultTextBox.TabIndex = 6;
            // 
            // plainLabel
            // 
            plainLabel.AutoSize = true;
            plainLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plainLabel.Location = new Point(50, 362);
            plainLabel.Name = "plainLabel";
            plainLabel.Size = new Size(211, 33);
            plainLabel.TabIndex = 7;
            plainLabel.Text = "Исходный текст:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(444, 362);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(134, 33);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "Результат:";
            // 
            // openButton
            // 
            openButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openButton.Location = new Point(83, 821);
            openButton.Name = "openButton";
            openButton.Size = new Size(282, 57);
            openButton.TabIndex = 9;
            openButton.Text = "Считать из файла";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += OpenFile;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(476, 821);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(282, 57);
            saveButton.TabIndex = 10;
            saveButton.Text = "Сохранить в файл";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveFile;
            // 
            // executeButton
            // 
            executeButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            executeButton.Location = new Point(280, 901);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(282, 57);
            executeButton.TabIndex = 11;
            executeButton.Text = "Выполнить";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // plainRadioButton
            // 
            plainRadioButton.AutoSize = true;
            plainRadioButton.Checked = true;
            plainRadioButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plainRadioButton.Location = new Point(33, 14);
            plainRadioButton.Name = "plainRadioButton";
            plainRadioButton.Size = new Size(228, 37);
            plainRadioButton.TabIndex = 0;
            plainRadioButton.TabStop = true;
            plainRadioButton.Text = "Исходный текст";
            plainRadioButton.UseVisualStyleBackColor = true;
            plainRadioButton.CheckedChanged += ChangeFileType;
            // 
            // cipherRadioButton
            // 
            cipherRadioButton.AutoSize = true;
            cipherRadioButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cipherRadioButton.Location = new Point(33, 57);
            cipherRadioButton.Name = "cipherRadioButton";
            cipherRadioButton.Size = new Size(306, 37);
            cipherRadioButton.TabIndex = 1;
            cipherRadioButton.Text = "Зашифрованный текст";
            cipherRadioButton.UseVisualStyleBackColor = true;
            // 
            // plainPanel
            // 
            plainPanel.Controls.Add(cipherRadioButton);
            plainPanel.Controls.Add(plainRadioButton);
            plainPanel.Location = new Point(50, 689);
            plainPanel.Name = "plainPanel";
            plainPanel.Size = new Size(347, 110);
            plainPanel.TabIndex = 12;
            // 
            // plainResRadioButton
            // 
            plainResRadioButton.AutoSize = true;
            plainResRadioButton.Enabled = false;
            plainResRadioButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plainResRadioButton.Location = new Point(32, 14);
            plainResRadioButton.Name = "plainResRadioButton";
            plainResRadioButton.Size = new Size(228, 37);
            plainResRadioButton.TabIndex = 0;
            plainResRadioButton.Text = "Исходный текст";
            plainResRadioButton.UseVisualStyleBackColor = true;
            // 
            // cipherResRadioButton
            // 
            cipherResRadioButton.AutoSize = true;
            cipherResRadioButton.Checked = true;
            cipherResRadioButton.Enabled = false;
            cipherResRadioButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cipherResRadioButton.Location = new Point(32, 57);
            cipherResRadioButton.Name = "cipherResRadioButton";
            cipherResRadioButton.Size = new Size(306, 37);
            cipherResRadioButton.TabIndex = 1;
            cipherResRadioButton.TabStop = true;
            cipherResRadioButton.Text = "Зашифрованный текст";
            cipherResRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultPanel
            // 
            resultPanel.Controls.Add(cipherResRadioButton);
            resultPanel.Controls.Add(plainResRadioButton);
            resultPanel.Location = new Point(444, 689);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(347, 110);
            resultPanel.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 998);
            Controls.Add(resultPanel);
            Controls.Add(plainPanel);
            Controls.Add(executeButton);
            Controls.Add(saveButton);
            Controls.Add(openButton);
            Controls.Add(resultLabel);
            Controls.Add(plainLabel);
            Controls.Add(resultTextBox);
            Controls.Add(plainTextBox);
            Controls.Add(groupBox);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лаба 3";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            plainPanel.ResumeLayout(false);
            plainPanel.PerformLayout();
            resultPanel.ResumeLayout(false);
            resultPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem очиститьВсеПоляToolStripMenuItem;
        private Label pLabel;
        private Label qLabel;
        private Label bLabel;
        private GroupBox groupBox;
        private TextBox pTextBox;
        private TextBox bTextBox;
        private TextBox qTextBox;
        private RadioButton decryptRadioButton;
        private RadioButton encryptRadioButton;
        private TextBox plainTextBox;
        private TextBox resultTextBox;
        private Label plainLabel;
        private Label resultLabel;
        private Button openButton;
        private Button saveButton;
        private Button executeButton;
        private RadioButton plainRadioButton;
        private RadioButton cipherRadioButton;
        private Panel plainPanel;
        private RadioButton plainResRadioButton;
        private RadioButton cipherResRadioButton;
        private Panel resultPanel;
        private OpenFileDialog plainOpenFileDialog;
        private OpenFileDialog cipherOpenFileDialog;
        private SaveFileDialog plainSaveFileDialog;
        private SaveFileDialog cipherSaveFileDialog;
    }
}
