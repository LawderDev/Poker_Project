namespace PokerProject
{
    partial class ExampleBetView
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
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betAmounButton = new System.Windows.Forms.Button();
            this.betAllButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.betAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betAmount.Font = new System.Drawing.Font("Carlito", 10F);
            this.betAmount.ForeColor = System.Drawing.Color.White;
            this.betAmount.Location = new System.Drawing.Point(151, 112);
            this.betAmount.Margin = new System.Windows.Forms.Padding(2);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(60, 24);
            this.betAmount.TabIndex = 0;
            // 
            // betAmounButton
            // 
            this.betAmounButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.betAmounButton.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.betAmounButton.Location = new System.Drawing.Point(236, 93);
            this.betAmounButton.Margin = new System.Windows.Forms.Padding(2);
            this.betAmounButton.Name = "betAmounButton";
            this.betAmounButton.Size = new System.Drawing.Size(83, 26);
            this.betAmounButton.TabIndex = 1;
            this.betAmounButton.Text = "Bet Amount";
            this.betAmounButton.UseVisualStyleBackColor = true;
            // 
            // betAllButton
            // 
            this.betAllButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.betAllButton.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.betAllButton.Location = new System.Drawing.Point(236, 123);
            this.betAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.betAllButton.Name = "betAllButton";
            this.betAllButton.Size = new System.Drawing.Size(83, 28);
            this.betAllButton.TabIndex = 2;
            this.betAllButton.Text = "Bet All";
            this.betAllButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.checkButton.Font = new System.Drawing.Font("Carlito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(236, 61);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(83, 28);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // foldButton
            // 
            this.foldButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.foldButton.Font = new System.Drawing.Font("Carlito", 11.25F);
            this.foldButton.Location = new System.Drawing.Point(236, 155);
            this.foldButton.Margin = new System.Windows.Forms.Padding(2);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(83, 28);
            this.foldButton.TabIndex = 4;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            // 
            // ExampleBetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.betAllButton);
            this.Controls.Add(this.betAmounButton);
            this.Controls.Add(this.betAmount);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExampleBetView";
            this.Text = "ExampleBetView";
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button betAmounButton;
        private System.Windows.Forms.Button betAllButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button foldButton;
    }
}