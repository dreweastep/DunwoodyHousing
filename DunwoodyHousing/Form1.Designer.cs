﻿namespace DunwoodyHousing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LogIn = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResidentSearch = new System.Windows.Forms.TabPage();
            this.NewResident = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.LogIn.SuspendLayout();
            this.Selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label1.Font = new System.Drawing.Font("Perpetua", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dunwoody Housing System";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LogIn);
            this.tabControl1.Controls.Add(this.Selection);
            this.tabControl1.Controls.Add(this.ResidentSearch);
            this.tabControl1.Controls.Add(this.NewResident);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Maroon;
            this.LogIn.Controls.Add(this.label5);
            this.LogIn.Controls.Add(this.button1);
            this.LogIn.Controls.Add(this.textBox2);
            this.LogIn.Controls.Add(this.label4);
            this.LogIn.Controls.Add(this.label3);
            this.LogIn.Controls.Add(this.textBox1);
            this.LogIn.Controls.Add(this.label2);
            this.LogIn.Controls.Add(this.label1);
            this.LogIn.Location = new System.Drawing.Point(4, 25);
            this.LogIn.Name = "LogIn";
            this.LogIn.Padding = new System.Windows.Forms.Padding(3);
            this.LogIn.Size = new System.Drawing.Size(545, 449);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log In ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(37, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "The username or password entered is incorrect.";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox2.Location = new System.Drawing.Point(211, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = 'J';
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(95, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(95, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(211, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(212, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Selection
            // 
            this.Selection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Selection.Controls.Add(this.button3);
            this.Selection.Controls.Add(this.button2);
            this.Selection.Controls.Add(this.pictureBox1);
            this.Selection.Location = new System.Drawing.Point(4, 25);
            this.Selection.Name = "Selection";
            this.Selection.Padding = new System.Windows.Forms.Padding(3);
            this.Selection.Size = new System.Drawing.Size(545, 449);
            this.Selection.TabIndex = 1;
            this.Selection.Text = "Selection";
            this.Selection.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(141, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create new resident ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search for existing residents";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResidentSearch
            // 
            this.ResidentSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResidentSearch.Location = new System.Drawing.Point(4, 25);
            this.ResidentSearch.Name = "ResidentSearch";
            this.ResidentSearch.Padding = new System.Windows.Forms.Padding(3);
            this.ResidentSearch.Size = new System.Drawing.Size(545, 449);
            this.ResidentSearch.TabIndex = 2;
            this.ResidentSearch.Text = "Resident Search";
            this.ResidentSearch.UseVisualStyleBackColor = true;
            // 
            // NewResident
            // 
            this.NewResident.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewResident.Location = new System.Drawing.Point(4, 25);
            this.NewResident.Name = "NewResident";
            this.NewResident.Padding = new System.Windows.Forms.Padding(3);
            this.NewResident.Size = new System.Drawing.Size(545, 449);
            this.NewResident.TabIndex = 3;
            this.NewResident.Text = "New Resident";
            this.NewResident.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 477);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.Selection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LogIn;
        private System.Windows.Forms.TabPage Selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage ResidentSearch;
        private System.Windows.Forms.TabPage NewResident;
    }
}

