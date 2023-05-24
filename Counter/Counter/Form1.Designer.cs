namespace Counter
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
            Add = new Button();
            Reset = new Button();
            Sub = new Button();
            Title = new Label();
            counter = new Label();
            Nome = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(186, 194);
            Add.Name = "Add";
            Add.Size = new Size(105, 100);
            Add.TabIndex = 0;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.Location = new Point(297, 194);
            Reset.Name = "Reset";
            Reset.Size = new Size(126, 100);
            Reset.TabIndex = 1;
            Reset.Text = "RESET";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Sub
            // 
            Sub.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Sub.Location = new Point(429, 194);
            Sub.Name = "Sub";
            Sub.Size = new Size(109, 100);
            Sub.TabIndex = 2;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(199, 114);
            Title.Name = "Title";
            Title.Size = new Size(251, 37);
            Title.TabIndex = 3;
            Title.Text = "Numero de Cliques:";
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            counter.Location = new Point(480, 114);
            counter.Name = "counter";
            counter.Size = new Size(32, 37);
            counter.TabIndex = 4;
            counter.Text = "0";
            counter.Click += counter_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(12, 395);
            Nome.Name = "Nome";
            Nome.Size = new Size(408, 37);
            Nome.TabIndex = 5;
            Nome.Text = "NOME:Vitor Rodrigues de Vargas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(426, 395);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 6;
            label1.Text = "RA: 2023103380";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Nome);
            Controls.Add(counter);
            Controls.Add(Title);
            Controls.Add(Sub);
            Controls.Add(Reset);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private Button Reset;
        private Button Sub;
        private Label Title;
        private Label counter;
        private Label Nome;
        private Label label1;
    }
}