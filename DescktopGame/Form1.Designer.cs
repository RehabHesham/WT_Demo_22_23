namespace DescktopGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.radP1O = new System.Windows.Forms.RadioButton();
            this.radP1X = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.radP2O = new System.Windows.Forms.RadioButton();
            this.radP2X = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to our game";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlayer1Name);
            this.groupBox1.Controls.Add(this.radP1O);
            this.groupBox1.Controls.Add(this.radP1X);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(95, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(31, 85);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(177, 35);
            this.txtPlayer1Name.TabIndex = 2;
            // 
            // radP1O
            // 
            this.radP1O.AutoSize = true;
            this.radP1O.Location = new System.Drawing.Point(152, 141);
            this.radP1O.Name = "radP1O";
            this.radP1O.Size = new System.Drawing.Size(47, 34);
            this.radP1O.TabIndex = 1;
            this.radP1O.TabStop = true;
            this.radP1O.Text = "O";
            this.radP1O.UseVisualStyleBackColor = true;
            this.radP1O.Click += new System.EventHandler(this.radP1O_Click);
            // 
            // radP1X
            // 
            this.radP1X.AutoSize = true;
            this.radP1X.Location = new System.Drawing.Point(52, 139);
            this.radP1X.Name = "radP1X";
            this.radP1X.Size = new System.Drawing.Size(45, 34);
            this.radP1X.TabIndex = 0;
            this.radP1X.TabStop = true;
            this.radP1X.Text = "X";
            this.radP1X.UseVisualStyleBackColor = true;
            this.radP1X.Click += new System.EventHandler(this.radP1X_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPlayer2Name);
            this.groupBox2.Controls.Add(this.radP2O);
            this.groupBox2.Controls.Add(this.radP2X);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(451, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(35, 85);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(177, 36);
            this.txtPlayer2Name.TabIndex = 4;
            // 
            // radP2O
            // 
            this.radP2O.AutoSize = true;
            this.radP2O.Location = new System.Drawing.Point(153, 141);
            this.radP2O.Name = "radP2O";
            this.radP2O.Size = new System.Drawing.Size(48, 34);
            this.radP2O.TabIndex = 1;
            this.radP2O.TabStop = true;
            this.radP2O.Text = "O";
            this.radP2O.UseVisualStyleBackColor = true;
            this.radP2O.Click += new System.EventHandler(this.radP2O_Click);
            // 
            // radP2X
            // 
            this.radP2X.AutoSize = true;
            this.radP2X.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radP2X.Location = new System.Drawing.Point(50, 141);
            this.radP2X.Name = "radP2X";
            this.radP2X.Size = new System.Drawing.Size(45, 34);
            this.radP2X.TabIndex = 0;
            this.radP2X.TabStop = true;
            this.radP2X.Text = "X";
            this.radP2X.UseVisualStyleBackColor = true;
            this.radP2X.Click += new System.EventHandler(this.radP2X_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(258, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(273, 64);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DescktopGame.Properties.Resources.greg_rosenke_6QnEf_b47eA_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radP1O;
        private RadioButton radP1X;
        private GroupBox groupBox2;
        private RadioButton radP2O;
        private RadioButton radP2X;
        private Label label2;
        private TextBox txtPlayer1Name;
        private Label label3;
        private TextBox txtPlayer2Name;
        private Button btnStart;
    }
}