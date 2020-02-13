namespace JSON_Record_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createJSON_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.word_lbl = new System.Windows.Forms.Label();
            this.word_textBox = new System.Windows.Forms.TextBox();
            this.translation_lbl = new System.Windows.Forms.Label();
            this.translation_textBox = new System.Windows.Forms.TextBox();
            this.romanized_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.phrase_lbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createJSON_btn
            // 
            this.createJSON_btn.Location = new System.Drawing.Point(658, 396);
            this.createJSON_btn.Name = "createJSON_btn";
            this.createJSON_btn.Size = new System.Drawing.Size(130, 42);
            this.createJSON_btn.TabIndex = 0;
            this.createJSON_btn.Text = "Create JSON";
            this.createJSON_btn.UseVisualStyleBackColor = true;
            this.createJSON_btn.Click += new System.EventHandler(this.CreateJSON_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(16, 13);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(131, 17);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "Web-safe record ID";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(16, 34);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(124, 22);
            this.id_textBox.TabIndex = 2;
            this.id_textBox.TextChanged += new System.EventHandler(this.Id_textBox_TextChanged);
            // 
            // word_lbl
            // 
            this.word_lbl.AutoSize = true;
            this.word_lbl.Location = new System.Drawing.Point(16, 64);
            this.word_lbl.Name = "word_lbl";
            this.word_lbl.Size = new System.Drawing.Size(42, 17);
            this.word_lbl.TabIndex = 3;
            this.word_lbl.Text = "Word";
            // 
            // word_textBox
            // 
            this.word_textBox.Location = new System.Drawing.Point(16, 84);
            this.word_textBox.Name = "word_textBox";
            this.word_textBox.Size = new System.Drawing.Size(124, 22);
            this.word_textBox.TabIndex = 4;
            // 
            // translation_lbl
            // 
            this.translation_lbl.AutoSize = true;
            this.translation_lbl.Location = new System.Drawing.Point(16, 172);
            this.translation_lbl.Name = "translation_lbl";
            this.translation_lbl.Size = new System.Drawing.Size(124, 17);
            this.translation_lbl.TabIndex = 5;
            this.translation_lbl.Text = "English translation";
            // 
            // translation_textBox
            // 
            this.translation_textBox.Location = new System.Drawing.Point(19, 192);
            this.translation_textBox.Name = "translation_textBox";
            this.translation_textBox.Size = new System.Drawing.Size(124, 22);
            this.translation_textBox.TabIndex = 6;
            // 
            // romanized_lbl
            // 
            this.romanized_lbl.AutoSize = true;
            this.romanized_lbl.Location = new System.Drawing.Point(16, 113);
            this.romanized_lbl.Name = "romanized_lbl";
            this.romanized_lbl.Size = new System.Drawing.Size(117, 17);
            this.romanized_lbl.TabIndex = 7;
            this.romanized_lbl.Text = "Romanized Word";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 8;
            // 
            // phrase_lbl
            // 
            this.phrase_lbl.AutoSize = true;
            this.phrase_lbl.Location = new System.Drawing.Point(169, 64);
            this.phrase_lbl.Name = "phrase_lbl";
            this.phrase_lbl.Size = new System.Drawing.Size(53, 17);
            this.phrase_lbl.TabIndex = 9;
            this.phrase_lbl.Text = "Phrase";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Romanized Phrase";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 22);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "# of Strokes";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 381);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 22);
            this.textBox4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Important Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.phrase_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.romanized_lbl);
            this.Controls.Add(this.translation_textBox);
            this.Controls.Add(this.translation_lbl);
            this.Controls.Add(this.word_textBox);
            this.Controls.Add(this.word_lbl);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.createJSON_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createJSON_btn;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label word_lbl;
        private System.Windows.Forms.TextBox word_textBox;
        private System.Windows.Forms.Label translation_lbl;
        private System.Windows.Forms.TextBox translation_textBox;
        private System.Windows.Forms.Label romanized_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label phrase_lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
    }
}

