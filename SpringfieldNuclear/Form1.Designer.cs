namespace SpringfieldNuclear
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(76, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(319, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Power Control";
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.ForeColor = System.Drawing.Color.White;
            this.reactor1Label.Location = new System.Drawing.Point(73, 112);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(88, 20);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            // 
            // reactor2Label
            // 
            this.reactor2Label.AutoSize = true;
            this.reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.ForeColor = System.Drawing.Color.White;
            this.reactor2Label.Location = new System.Drawing.Point(302, 112);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(88, 20);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LightGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(44, 157);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(147, 106);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LightGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(274, 157);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(147, 106);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Caslon540 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.SlateGray;
            this.outputLabel.Location = new System.Drawing.Point(72, 346);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(325, 45);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactor Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.SlateGray;
            this.startButton.Location = new System.Drawing.Point(187, 281);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 45);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(488, 439);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Springfield Power Plant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

