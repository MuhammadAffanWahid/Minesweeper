namespace Mine_Sweeper
{
    partial class Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Board = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Beginner);
            this.panel1.Controls.Add(this.Expert);
            this.panel1.Controls.Add(this.Intermediate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 131);
            this.panel1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(235, 88);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 40);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Clicked);
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Location = new System.Drawing.Point(40, 24);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(67, 17);
            this.Beginner.TabIndex = 0;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(470, 24);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(55, 17);
            this.Expert.TabIndex = 0;
            this.Expert.TabStop = true;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Location = new System.Drawing.Point(249, 24);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(83, 17);
            this.Intermediate.TabIndex = 0;
            this.Intermediate.TabStop = true;
            this.Intermediate.Text = "Intermediate";
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.Board.Controls.Add(this.panel1);
            this.Board.Location = new System.Drawing.Point(12, 65);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(591, 570);
            this.Board.TabIndex = 1;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 647);
            this.Controls.Add(this.Board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minesweeper";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel Board;
    }
}

