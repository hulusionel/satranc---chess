namespace YazılımYapimi2_satranç
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
            this.btnYeni = new System.Windows.Forms.Button();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd6 = new System.Windows.Forms.RadioButton();
            this.rd7 = new System.Windows.Forms.RadioButton();
            this.rd8 = new System.Windows.Forms.RadioButton();
            this.rd9 = new System.Windows.Forms.RadioButton();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHamle = new System.Windows.Forms.Label();
            this.lblwinlose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(116, 12);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni Oyun";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(20, 12);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(42, 17);
            this.rd5.TabIndex = 1;
            this.rd5.TabStop = true;
            this.rd5.Text = "5x5";
            this.rd5.UseVisualStyleBackColor = true;
            // 
            // rd6
            // 
            this.rd6.AutoSize = true;
            this.rd6.Location = new System.Drawing.Point(68, 12);
            this.rd6.Name = "rd6";
            this.rd6.Size = new System.Drawing.Size(42, 17);
            this.rd6.TabIndex = 2;
            this.rd6.TabStop = true;
            this.rd6.Text = "6x6";
            this.rd6.UseVisualStyleBackColor = true;
            // 
            // rd7
            // 
            this.rd7.AutoSize = true;
            this.rd7.Location = new System.Drawing.Point(20, 39);
            this.rd7.Name = "rd7";
            this.rd7.Size = new System.Drawing.Size(42, 17);
            this.rd7.TabIndex = 1;
            this.rd7.TabStop = true;
            this.rd7.Text = "7x7";
            this.rd7.UseVisualStyleBackColor = true;
            // 
            // rd8
            // 
            this.rd8.AutoSize = true;
            this.rd8.Location = new System.Drawing.Point(68, 39);
            this.rd8.Name = "rd8";
            this.rd8.Size = new System.Drawing.Size(42, 17);
            this.rd8.TabIndex = 2;
            this.rd8.TabStop = true;
            this.rd8.Text = "8x8";
            this.rd8.UseVisualStyleBackColor = true;
            // 
            // rd9
            // 
            this.rd9.AutoSize = true;
            this.rd9.Location = new System.Drawing.Point(45, 62);
            this.rd9.Name = "rd9";
            this.rd9.Size = new System.Drawing.Size(42, 17);
            this.rd9.TabIndex = 2;
            this.rd9.TabStop = true;
            this.rd9.Text = "9x9";
            this.rd9.UseVisualStyleBackColor = true;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgView.ColumnHeadersHeight = 10;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgView.ColumnHeadersVisible = false;
            this.dgView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgView.Location = new System.Drawing.Point(36, 125);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersVisible = false;
            this.dgView.RowHeadersWidth = 60;
            this.dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgView.Size = new System.Drawing.Size(227, 236);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(116, 39);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblDurum.Location = new System.Drawing.Point(269, 15);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Olası Hamle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hamle Sayısı :";
            // 
            // lblHamle
            // 
            this.lblHamle.AutoSize = true;
            this.lblHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHamle.ForeColor = System.Drawing.Color.Brown;
            this.lblHamle.Location = new System.Drawing.Point(274, 41);
            this.lblHamle.Name = "lblHamle";
            this.lblHamle.Size = new System.Drawing.Size(0, 20);
            this.lblHamle.TabIndex = 4;
            // 
            // lblwinlose
            // 
            this.lblwinlose.AutoSize = true;
            this.lblwinlose.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblwinlose.ForeColor = System.Drawing.Color.DarkRed;
            this.lblwinlose.Location = new System.Drawing.Point(110, 65);
            this.lblwinlose.Name = "lblwinlose";
            this.lblwinlose.Size = new System.Drawing.Size(0, 33);
            this.lblwinlose.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 496);
            this.Controls.Add(this.lblwinlose);
            this.Controls.Add(this.lblHamle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.rd9);
            this.Controls.Add(this.rd8);
            this.Controls.Add(this.rd7);
            this.Controls.Add(this.rd6);
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnYeni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd6;
        private System.Windows.Forms.RadioButton rd7;
        private System.Windows.Forms.RadioButton rd8;
        private System.Windows.Forms.RadioButton rd9;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHamle;
        private System.Windows.Forms.Label lblwinlose;
    }
}

