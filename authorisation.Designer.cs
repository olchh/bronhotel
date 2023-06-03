using System.Windows.Forms;

namespace bronhotel2
{
    partial class authorisation
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
            this.panel_Auth = new System.Windows.Forms.Panel();
            this.close_Auth = new System.Windows.Forms.Label();
            this.enter_button_Auth = new System.Windows.Forms.Button();
            this.password_Auth = new System.Windows.Forms.TextBox();
            this.login_Auth = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Auth.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Auth
            // 
            this.panel_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.panel_Auth.Controls.Add(this.close_Auth);
            this.panel_Auth.Controls.Add(this.pictureBox2);
            this.panel_Auth.Controls.Add(this.enter_button_Auth);
            this.panel_Auth.Controls.Add(this.password_Auth);
            this.panel_Auth.Controls.Add(this.login_Auth);
            this.panel_Auth.Controls.Add(this.pictureBox1);
            this.panel_Auth.Controls.Add(this.panel2);
            this.panel_Auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Auth.Location = new System.Drawing.Point(0, 0);
            this.panel_Auth.Name = "panel_Auth";
            this.panel_Auth.Size = new System.Drawing.Size(716, 512);
            this.panel_Auth.TabIndex = 0;
            this.panel_Auth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Auth_MouseDown);
            this.panel_Auth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Auth_MouseMove);
            // 
            // close_Auth
            // 
            this.close_Auth.AutoSize = true;
            this.close_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Auth.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Auth.Location = new System.Drawing.Point(665, 0);
            this.close_Auth.Name = "close_Auth";
            this.close_Auth.Size = new System.Drawing.Size(39, 54);
            this.close_Auth.TabIndex = 8;
            this.close_Auth.Text = "x";
            this.close_Auth.Click += new System.EventHandler(this.close_Auth_Click);
            this.close_Auth.MouseEnter += new System.EventHandler(this.close_Auth_MouseEnter);
            this.close_Auth.MouseLeave += new System.EventHandler(this.close_Auth_MouseLeave);
            // 
            // enter_button_Auth
            // 
            this.enter_button_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_button_Auth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enter_button_Auth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(132)))), ((int)(((byte)(118)))));
            this.enter_button_Auth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(111)))));
            this.enter_button_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button_Auth.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button_Auth.Location = new System.Drawing.Point(274, 398);
            this.enter_button_Auth.Name = "enter_button_Auth";
            this.enter_button_Auth.Size = new System.Drawing.Size(139, 57);
            this.enter_button_Auth.TabIndex = 6;
            this.enter_button_Auth.Text = "enter";
            this.enter_button_Auth.UseVisualStyleBackColor = true;
            this.enter_button_Auth.Click += new System.EventHandler(this.enter_button_Auth_Click);
            // 
            // password_Auth
            // 
            this.password_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.password_Auth.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.password_Auth.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Auth.Location = new System.Drawing.Point(244, 311);
            this.password_Auth.Name = "password_Auth";
            this.password_Auth.Size = new System.Drawing.Size(242, 48);
            this.password_Auth.TabIndex = 5;
            this.password_Auth.UseSystemPasswordChar = true;
            // 
            // login_Auth
            // 
            this.login_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.login_Auth.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.login_Auth.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Auth.Location = new System.Drawing.Point(244, 234);
            this.login_Auth.Multiline = true;
            this.login_Auth.Name = "login_Auth";
            this.login_Auth.Size = new System.Drawing.Size(242, 50);
            this.login_Auth.TabIndex = 3;
            this.login_Auth.Enter += new System.EventHandler(this.login_Auth_Enter);
            this.login_Auth.Leave += new System.EventHandler(this.login_Auth_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(213, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 110);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "authorisation";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bronhotel2.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(193, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bronhotel2.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(193, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 512);
            this.Controls.Add(this.panel_Auth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "authorisation";
            this.panel_Auth.ResumeLayout(false);
            this.panel_Auth.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_Auth;
        private PictureBox pictureBox2;
        private Button enter_button_Auth;
        private TextBox password_Auth;
        private TextBox login_Auth;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label close_Auth;
    }
}