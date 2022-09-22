namespace PokerProject
{
    partial class Discard
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
            this.listBoxCard = new System.Windows.Forms.ListBox();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCard
            // 
            this.listBoxCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCard.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCard.ForeColor = System.Drawing.Color.White;
            this.listBoxCard.FormattingEnabled = true;
            this.listBoxCard.ItemHeight = 19;
            this.listBoxCard.Location = new System.Drawing.Point(302, 12);
            this.listBoxCard.Name = "listBoxCard";
            this.listBoxCard.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCard.Size = new System.Drawing.Size(166, 211);
            this.listBoxCard.TabIndex = 0;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscard.Location = new System.Drawing.Point(101, 181);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(88, 34);
            this.buttonDiscard.TabIndex = 1;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // Discard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.listBoxCard);
            this.Name = "Discard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCard;
        private System.Windows.Forms.Button buttonDiscard;
    }
}