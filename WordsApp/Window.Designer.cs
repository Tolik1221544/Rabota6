namespace WordsApp
{
    partial class Window
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
            this.Split = new System.Windows.Forms.Splitter();
            this.TextsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumberBox)).BeginInit();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Split
            // 
            this.Split.Location = new System.Drawing.Point(0, 0);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(555, 536);
            this.Split.TabIndex = 1;
            this.Split.TabStop = false;
            // 
            // TextsBox
            // 
            this.TextsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextsBox.FormattingEnabled = true;
            this.TextsBox.ItemHeight = 19;
            this.TextsBox.Items.AddRange(new object[] {
            "This beutiful text.",
            "Hello, my world."});
            this.TextsBox.Location = new System.Drawing.Point(12, 34);
            this.TextsBox.Name = "TextsBox";
            this.TextsBox.Size = new System.Drawing.Size(543, 441);
            this.TextsBox.TabIndex = 2;
            this.TextsBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "i-тый номер:";
            // 
            // FirstNumberBox
            // 
            this.FirstNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNumberBox.Location = new System.Drawing.Point(687, 34);
            this.FirstNumberBox.Name = "FirstNumberBox";
            this.FirstNumberBox.Size = new System.Drawing.Size(409, 26);
            this.FirstNumberBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст на выбор:";
            // 
            // SecondNumberBox
            // 
            this.SecondNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondNumberBox.Location = new System.Drawing.Point(687, 70);
            this.SecondNumberBox.Name = "SecondNumberBox";
            this.SecondNumberBox.Size = new System.Drawing.Size(409, 26);
            this.SecondNumberBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "j-тый номер:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(561, 106);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(535, 31);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Поменять местами";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultGroup
            // 
            this.ResultGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultGroup.Controls.Add(this.ResultLabel);
            this.ResultGroup.Location = new System.Drawing.Point(565, 143);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(531, 381);
            this.ResultGroup.TabIndex = 9;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Результат";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResultLabel.Location = new System.Drawing.Point(6, 26);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(95, 21);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = " Результат.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(683, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Индексация с 0";
            // 
            // AddBox
            // 
            this.AddBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBox.Location = new System.Drawing.Point(12, 494);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(434, 26);
            this.AddBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(452, 494);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 30);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 536);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SecondNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextsBox);
            this.Controls.Add(this.Split);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слова";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumberBox)).EndInit();
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter Split;
        private System.Windows.Forms.ListBox TextsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FirstNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SecondNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Button AddButton;
    }
}

