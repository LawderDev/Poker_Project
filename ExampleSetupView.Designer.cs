namespace PokerProject
{
    partial class ExampleSetupView
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
            this.listBoxChoice = new System.Windows.Forms.ListBox();
            this.labelChoice = new System.Windows.Forms.Label();
            this.labelNbPlayers = new System.Windows.Forms.Label();
            this.labelHA = new System.Windows.Forms.Label();
            this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownAnte = new System.Windows.Forms.NumericUpDown();
            this.labelAnte = new System.Windows.Forms.Label();
            this.checkBoxDouble = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnte)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChoice
            // 
            this.listBoxChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxChoice.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxChoice.ForeColor = System.Drawing.Color.White;
            this.listBoxChoice.FormattingEnabled = true;
            this.listBoxChoice.ItemHeight = 14;
            this.listBoxChoice.Location = new System.Drawing.Point(118, 29);
            this.listBoxChoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxChoice.Name = "listBoxChoice";
            this.listBoxChoice.Size = new System.Drawing.Size(104, 44);
            this.listBoxChoice.TabIndex = 0;
            this.listBoxChoice.SelectedIndexChanged += new System.EventHandler(this.ListBoxChoice_SelectedIndexChanged);
            // 
            // labelChoice
            // 
            this.labelChoice.AutoSize = true;
            this.labelChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.labelChoice.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoice.ForeColor = System.Drawing.Color.White;
            this.labelChoice.Location = new System.Drawing.Point(15, 29);
            this.labelChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoice.Name = "labelChoice";
            this.labelChoice.Size = new System.Drawing.Size(72, 14);
            this.labelChoice.TabIndex = 1;
            this.labelChoice.Text = "Game Choice";
            // 
            // labelNbPlayers
            // 
            this.labelNbPlayers.AutoSize = true;
            this.labelNbPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.labelNbPlayers.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.labelNbPlayers.ForeColor = System.Drawing.Color.White;
            this.labelNbPlayers.Location = new System.Drawing.Point(15, 98);
            this.labelNbPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNbPlayers.Name = "labelNbPlayers";
            this.labelNbPlayers.Size = new System.Drawing.Size(99, 14);
            this.labelNbPlayers.TabIndex = 2;
            this.labelNbPlayers.Text = "Number of players";
            // 
            // labelHA
            // 
            this.labelHA.AutoSize = true;
            this.labelHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.labelHA.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.labelHA.ForeColor = System.Drawing.Color.White;
            this.labelHA.Location = new System.Drawing.Point(15, 143);
            this.labelHA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHA.Name = "labelHA";
            this.labelHA.Size = new System.Drawing.Size(49, 14);
            this.labelHA.TabIndex = 3;
            this.labelHA.Text = "Human?";
            // 
            // numericUpDownPlayers
            // 
            this.numericUpDownPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numericUpDownPlayers.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.numericUpDownPlayers.ForeColor = System.Drawing.Color.White;
            this.numericUpDownPlayers.Location = new System.Drawing.Point(118, 98);
            this.numericUpDownPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPlayers.Name = "numericUpDownPlayers";
            this.numericUpDownPlayers.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownPlayers.TabIndex = 6;
            this.numericUpDownPlayers.ValueChanged += new System.EventHandler(this.NumericUpDownPlayers_ValueChanged);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidate.Location = new System.Drawing.Point(349, 298);
            this.buttonValidate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(80, 35);
            this.buttonValidate.TabIndex = 17;
            this.buttonValidate.Text = "VALIDATE";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonQuit.Location = new System.Drawing.Point(479, 298);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(80, 35);
            this.buttonQuit.TabIndex = 18;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.labelName.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(16, 203);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 14);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // numericUpDownAnte
            // 
            this.numericUpDownAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numericUpDownAnte.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAnte.ForeColor = System.Drawing.Color.White;
            this.numericUpDownAnte.Location = new System.Drawing.Point(118, 269);
            this.numericUpDownAnte.Name = "numericUpDownAnte";
            this.numericUpDownAnte.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownAnte.TabIndex = 24;
            // 
            // labelAnte
            // 
            this.labelAnte.AutoSize = true;
            this.labelAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.labelAnte.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.labelAnte.ForeColor = System.Drawing.Color.White;
            this.labelAnte.Location = new System.Drawing.Point(16, 269);
            this.labelAnte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnte.Name = "labelAnte";
            this.labelAnte.Size = new System.Drawing.Size(30, 14);
            this.labelAnte.TabIndex = 25;
            this.labelAnte.Text = "Ante";
            // 
            // checkBoxDouble
            // 
            this.checkBoxDouble.AutoSize = true;
            this.checkBoxDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.checkBoxDouble.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxDouble.ForeColor = System.Drawing.Color.White;
            this.checkBoxDouble.Location = new System.Drawing.Point(284, 272);
            this.checkBoxDouble.Name = "checkBoxDouble";
            this.checkBoxDouble.Size = new System.Drawing.Size(61, 18);
            this.checkBoxDouble.TabIndex = 31;
            this.checkBoxDouble.Text = "Double";
            this.checkBoxDouble.UseVisualStyleBackColor = false;
            // 
            // ExampleSetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.checkBoxDouble);
            this.Controls.Add(this.labelAnte);
            this.Controls.Add(this.numericUpDownAnte);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.numericUpDownPlayers);
            this.Controls.Add(this.labelHA);
            this.Controls.Add(this.labelNbPlayers);
            this.Controls.Add(this.labelChoice);
            this.Controls.Add(this.listBoxChoice);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ExampleSetupView";
            this.Text = "SetupView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ExampleSetupView_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChoice;
        private System.Windows.Forms.Label labelChoice;
        private System.Windows.Forms.Label labelNbPlayers;
        private System.Windows.Forms.Label labelHA;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayers;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown numericUpDownAnte;
        private System.Windows.Forms.Label labelAnte;
        private System.Windows.Forms.CheckBox checkBoxDouble;
    }
}