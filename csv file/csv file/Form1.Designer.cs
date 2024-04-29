namespace csv_file
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 70);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 3;
            label1.Text = "لطفا اطلاعات خواسته شده را وارد نمایید";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 132);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 4;
            label2.Text = "نام";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 204);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 272);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "شماره تماس";
            // 
            // button1
            // 
            button1.Location = new Point(90, 324);
            button1.Name = "button1";
            button1.Size = new Size(197, 64);
            button1.TabIndex = 7;
            button1.Text = "ثبت اطلاعات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 418);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
