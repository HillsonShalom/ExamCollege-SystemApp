namespace ExamCollege_SystemApp
{
    partial class SystemForm
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
            table = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(26, 332);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(868, 223);
            table.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 112);
            button1.Name = "button1";
            button1.Size = new Size(150, 44);
            button1.TabIndex = 1;
            button1.Text = "כמה נרשמו";
            button1.UseVisualStyleBackColor = true;
            button1.Click += how_much_students;
            // 
            // button2
            // 
            button2.Location = new Point(26, 47);
            button2.Name = "button2";
            button2.Size = new Size(150, 44);
            button2.TabIndex = 2;
            button2.Text = "כל הקורסים";
            button2.UseVisualStyleBackColor = true;
            button2.Click += get_all_courses;
            // 
            // button3
            // 
            button3.Location = new Point(26, 181);
            button3.Name = "button3";
            button3.Size = new Size(150, 44);
            button3.TabIndex = 3;
            button3.Text = "סה\"כ למרצים";
            button3.UseVisualStyleBackColor = true;
            button3.Click += sum_for_lecturers;
            // 
            // button4
            // 
            button4.Location = new Point(744, 47);
            button4.Name = "button4";
            button4.Size = new Size(150, 44);
            button4.TabIndex = 4;
            button4.Text = "תשלומים";
            button4.UseVisualStyleBackColor = true;
            button4.Click += all_payments;
            // 
            // button5
            // 
            button5.Location = new Point(744, 112);
            button5.Name = "button5";
            button5.Size = new Size(150, 44);
            button5.TabIndex = 5;
            button5.Text = "תלמידים";
            button5.UseVisualStyleBackColor = true;
            button5.Click += all_students;
            // 
            // SystemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 583);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(table);
            Name = "SystemForm";
            Text = "SystemForm";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView table;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}