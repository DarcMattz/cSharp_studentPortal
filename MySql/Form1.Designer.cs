using System.Windows.Forms;

namespace MySql
{
    partial class Main
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnrollmentBtn = new FontAwesome.Sharp.IconButton();
            this.SubjectsBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.Exit = new FontAwesome.Sharp.IconButton();
            this.header = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.EnrollmentBtn);
            this.sidebar.Controls.Add(this.SubjectsBtn);
            this.sidebar.Controls.Add(this.HomeBtn);
            this.sidebar.Location = new System.Drawing.Point(-9, -9);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(148, 715);
            this.sidebar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySql.Properties.Resources.JV_logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EnrollmentBtn
            // 
            this.EnrollmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.EnrollmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnrollmentBtn.FlatAppearance.BorderSize = 0;
            this.EnrollmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.EnrollmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(82)))));
            this.EnrollmentBtn.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.EnrollmentBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(82)))));
            this.EnrollmentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EnrollmentBtn.IconSize = 40;
            this.EnrollmentBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnrollmentBtn.Location = new System.Drawing.Point(3, 444);
            this.EnrollmentBtn.Name = "EnrollmentBtn";
            this.EnrollmentBtn.Size = new System.Drawing.Size(144, 71);
            this.EnrollmentBtn.TabIndex = 5;
            this.EnrollmentBtn.Text = "Enrollment";
            this.EnrollmentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EnrollmentBtn.UseVisualStyleBackColor = false;
            this.EnrollmentBtn.Click += new System.EventHandler(this.EnrollmentBtn_Click);
            // 
            // SubjectsBtn
            // 
            this.SubjectsBtn.AutoSize = true;
            this.SubjectsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubjectsBtn.FlatAppearance.BorderSize = 0;
            this.SubjectsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.SubjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(82)))));
            this.SubjectsBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.SubjectsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(77)))), ((int)(((byte)(82)))));
            this.SubjectsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubjectsBtn.IconSize = 40;
            this.SubjectsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SubjectsBtn.Location = new System.Drawing.Point(3, 315);
            this.SubjectsBtn.Name = "SubjectsBtn";
            this.SubjectsBtn.Size = new System.Drawing.Size(144, 71);
            this.SubjectsBtn.TabIndex = 4;
            this.SubjectsBtn.Text = "Subjects";
            this.SubjectsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SubjectsBtn.UseVisualStyleBackColor = false;
            this.SubjectsBtn.Click += new System.EventHandler(this.SubjectsBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.HomeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(207)))), ((int)(((byte)(136)))));
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 40;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HomeBtn.Location = new System.Drawing.Point(3, 188);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(144, 71);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.Location = new System.Drawing.Point(908, 24);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 51);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.header.Controls.Add(this.Exit);
            this.header.Location = new System.Drawing.Point(131, -9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1001, 98);
            this.header.TabIndex = 6;
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(145, 95);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(948, 582);
            this.Container.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1105, 689);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton EnrollmentBtn;
        private FontAwesome.Sharp.IconButton SubjectsBtn;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Container;
    }
}

