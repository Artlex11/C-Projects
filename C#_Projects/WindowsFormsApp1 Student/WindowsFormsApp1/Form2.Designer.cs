namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Exam = new System.Windows.Forms.TextBox();
            this.CourseWork = new System.Windows.Forms.TextBox();
            this.AverageBall = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФАМИЛИЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИМЯ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Экзамен";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Курсовая работа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Группа";
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Items.AddRange(new object[] {
            "\"РФ-425\"",
            "\"РФ-426\"",
            "\"РФ-427\"",
            " \"РФ-428\"",
            " \"РФ-429\""});
            this.Box1.Location = new System.Drawing.Point(79, 287);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(121, 28);
            this.Box1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(79, 567);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Вычислить средний балл";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Загрузить фото";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(730, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(79, 109);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(196, 42);
            this.LastName.TabIndex = 14;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(79, 198);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 45);
            this.FirstName.TabIndex = 15;
            // 
            // Exam
            // 
            this.Exam.Location = new System.Drawing.Point(79, 380);
            this.Exam.Multiline = true;
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(196, 44);
            this.Exam.TabIndex = 16;
            // 
            // CourseWork
            // 
            this.CourseWork.Location = new System.Drawing.Point(79, 496);
            this.CourseWork.Multiline = true;
            this.CourseWork.Name = "CourseWork";
            this.CourseWork.Size = new System.Drawing.Size(196, 43);
            this.CourseWork.TabIndex = 17;
            // 
            // AverageBall
            // 
            this.AverageBall.Location = new System.Drawing.Point(79, 597);
            this.AverageBall.Name = "AverageBall";
            this.AverageBall.Size = new System.Drawing.Size(196, 26);
            this.AverageBall.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(415, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 430);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 718);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(730, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Список студентов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 825);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AverageBall);
            this.Controls.Add(this.CourseWork);
            this.Controls.Add(this.Exam);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Exam;
        private System.Windows.Forms.TextBox CourseWork;
        private System.Windows.Forms.TextBox AverageBall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}