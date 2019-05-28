namespace Decoder
{
    partial class Coder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coder));
            this.Encode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ByteText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DecodedText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncodedText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceText = new System.Windows.Forms.RichTextBox();
            this.Key = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Decode = new System.Windows.Forms.Button();
            this.ReadFromFile = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(12, 403);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(119, 47);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Зашифровать текст";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Битовое представление текста";
            // 
            // ByteText
            // 
            this.ByteText.Location = new System.Drawing.Point(538, 30);
            this.ByteText.Name = "ByteText";
            this.ByteText.Size = new System.Drawing.Size(250, 170);
            this.ByteText.TabIndex = 4;
            this.ByteText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Расшифрованный текст";
            // 
            // DecodedText
            // 
            this.DecodedText.Location = new System.Drawing.Point(538, 227);
            this.DecodedText.Name = "DecodedText";
            this.DecodedText.Size = new System.Drawing.Size(250, 170);
            this.DecodedText.TabIndex = 6;
            this.DecodedText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Зашифрованный текст";
            // 
            // EncodedText
            // 
            this.EncodedText.Location = new System.Drawing.Point(12, 227);
            this.EncodedText.Name = "EncodedText";
            this.EncodedText.Size = new System.Drawing.Size(236, 170);
            this.EncodedText.TabIndex = 8;
            this.EncodedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Исходный текст";
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(12, 30);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(236, 170);
            this.SourceText.TabIndex = 10;
            this.SourceText.Text = "";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(295, 372);
            this.Key.Multiline = false;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(210, 26);
            this.Key.TabIndex = 12;
            this.Key.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ключ";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(649, 403);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(138, 47);
            this.Decode.TabIndex = 14;
            this.Decode.Text = "Расшифровать текст";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.Location = new System.Drawing.Point(137, 404);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(111, 46);
            this.ReadFromFile.TabIndex = 15;
            this.ReadFromFile.Text = "Загрузить из файла";
            this.ReadFromFile.UseVisualStyleBackColor = true;
            this.ReadFromFile.Click += new System.EventHandler(this.ReadFromFile_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(511, 404);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(132, 46);
            this.SaveToFile.TabIndex = 16;
            this.SaveToFile.Text = "Сохранить в файл";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // Coder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncodedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecodedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ByteText);
            this.Controls.Add(this.Encode);
            this.Name = "Coder";
            this.Text = "Шифратор";
            this.Load += new System.EventHandler(this.Coder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ByteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DecodedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox EncodedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SourceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.RichTextBox Key;
        private System.Windows.Forms.Button ReadFromFile;
        private System.Windows.Forms.Button SaveToFile;
    }
}

