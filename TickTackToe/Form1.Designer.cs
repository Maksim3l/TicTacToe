
namespace TickTackToe
{
    partial class TitleScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player2NB = new System.Windows.Forms.TextBox();
            this.Player1N = new System.Windows.Forms.TextBox();
            this.QuitB = new System.Windows.Forms.Button();
            this.PlayB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(111, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 74);
            this.label3.TabIndex = 19;
            this.label3.Text = "Player 2:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(111, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 74);
            this.label2.TabIndex = 18;
            this.label2.Text = "Player 1:";
            this.label2.Visible = false;
            // 
            // Player2NB
            // 
            this.Player2NB.BackColor = System.Drawing.Color.Gray;
            this.Player2NB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2NB.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player2NB.ForeColor = System.Drawing.Color.DarkGray;
            this.Player2NB.Location = new System.Drawing.Point(387, 233);
            this.Player2NB.Name = "Player2NB";
            this.Player2NB.Size = new System.Drawing.Size(263, 77);
            this.Player2NB.TabIndex = 17;
            this.Player2NB.Visible = false;
            this.Player2NB.TextChanged += new System.EventHandler(this.Player2N_TextChanged);
            // 
            // Player1N
            // 
            this.Player1N.BackColor = System.Drawing.Color.Gray;
            this.Player1N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1N.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player1N.ForeColor = System.Drawing.Color.DarkGray;
            this.Player1N.Location = new System.Drawing.Point(387, 98);
            this.Player1N.Name = "Player1N";
            this.Player1N.Size = new System.Drawing.Size(263, 77);
            this.Player1N.TabIndex = 16;
            this.Player1N.Visible = false;
            this.Player1N.TextChanged += new System.EventHandler(this.Player1N_TextChanged);
            // 
            // QuitB
            // 
            this.QuitB.BackColor = System.Drawing.Color.Gray;
            this.QuitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitB.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitB.ForeColor = System.Drawing.Color.DarkGray;
            this.QuitB.Location = new System.Drawing.Point(441, 270);
            this.QuitB.Name = "QuitB";
            this.QuitB.Size = new System.Drawing.Size(209, 85);
            this.QuitB.TabIndex = 15;
            this.QuitB.Text = "Quit";
            this.QuitB.UseVisualStyleBackColor = false;
            this.QuitB.Click += new System.EventHandler(this.QuitB_Click_1);
            // 
            // PlayB
            // 
            this.PlayB.BackColor = System.Drawing.Color.Gray;
            this.PlayB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayB.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.PlayB.Location = new System.Drawing.Point(132, 270);
            this.PlayB.Name = "PlayB";
            this.PlayB.Size = new System.Drawing.Size(209, 85);
            this.PlayB.TabIndex = 14;
            this.PlayB.Text = "Play";
            this.PlayB.UseVisualStyleBackColor = false;
            this.PlayB.Click += new System.EventHandler(this.PlayB_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 114);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tick Tack Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.Color.Gray;
            this.StartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartB.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartB.Location = new System.Drawing.Point(441, 327);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(209, 85);
            this.StartB.TabIndex = 20;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Visible = false;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player2NB);
            this.Controls.Add(this.Player1N);
            this.Controls.Add(this.QuitB);
            this.Controls.Add(this.PlayB);
            this.Controls.Add(this.label1);
            this.Name = "TitleScreen";
            this.Text = "TickTackToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Player2NB;
        private System.Windows.Forms.TextBox Player1N;
        private System.Windows.Forms.Button QuitB;
        private System.Windows.Forms.Button PlayB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartB;
    }
}

