namespace Albashiti_Mariam_25_26_ProjetC_ProgEven
{
    partial class Mariam1
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
            btnName = new Button();
            lblTest = new Label();
            pictureBox1 = new PictureBox();
            btnName2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnName
            // 
            btnName.Anchor = AnchorStyles.None;
            btnName.AutoSize = true;
            btnName.Cursor = Cursors.Hand;
            btnName.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnName.ForeColor = Color.OliveDrab;
            btnName.Location = new Point(254, 36);
            btnName.Name = "btnName";
            btnName.Size = new Size(200, 40);
            btnName.TabIndex = 0;
            btnName.Text = "Maryoma";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += button1_Click;
            // 
            // lblTest
            // 
            lblTest.Anchor = AnchorStyles.None;
            lblTest.AutoSize = true;
            lblTest.BackColor = SystemColors.ActiveCaption;
            lblTest.FlatStyle = FlatStyle.Flat;
            lblTest.ForeColor = Color.IndianRed;
            lblTest.Location = new Point(12, 36);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(199, 20);
            lblTest.TabIndex = 1;
            lblTest.Text = "Mariam ALBASHITI B2Q2 IS2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9b4fc1daa920440a8c03e8d9ae105bdf;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(12, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnName2
            // 
            btnName2.Anchor = AnchorStyles.None;
            btnName2.AutoSize = true;
            btnName2.Cursor = Cursors.Hand;
            btnName2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnName2.ForeColor = Color.OliveDrab;
            btnName2.Location = new Point(440, 437);
            btnName2.Name = "btnName2";
            btnName2.Size = new Size(200, 40);
            btnName2.TabIndex = 3;
            btnName2.Text = "Maryoma";
            btnName2.UseVisualStyleBackColor = true;
            btnName2.Click += btnName2_Click;
            // 
            // Mariam1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(934, 489);
            Controls.Add(btnName2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTest);
            Controls.Add(btnName);
            Cursor = Cursors.Cross;
            Name = "Mariam1";
            Text = "Mon application agreable ";
            Load += Mariam1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnName;
        private Label lblTest;
        private PictureBox pictureBox1;
        private Button btnName2;
    }
}
