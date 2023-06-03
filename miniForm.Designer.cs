namespace bronhotel2
{
    partial class miniForm
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
            this.mini_data = new System.Windows.Forms.TextBox();
            this.mini_days = new System.Windows.Forms.TextBox();
            this.mini_nomer = new System.Windows.Forms.TextBox();
            this.bron_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.close_miniForm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mini_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mini_data
            // 
            this.mini_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.mini_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_data.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_data.Location = new System.Drawing.Point(225, 251);
            this.mini_data.Name = "mini_data";
            this.mini_data.Size = new System.Drawing.Size(125, 38);
            this.mini_data.TabIndex = 1;
            // 
            // mini_days
            // 
            this.mini_days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.mini_days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini_days.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_days.Location = new System.Drawing.Point(471, 303);
            this.mini_days.Name = "mini_days";
            this.mini_days.Size = new System.Drawing.Size(43, 38);
            this.mini_days.TabIndex = 2;
            // 
            // mini_nomer
            // 
            this.mini_nomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.mini_nomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mini_nomer.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_nomer.Location = new System.Drawing.Point(319, 359);
            this.mini_nomer.Name = "mini_nomer";
            this.mini_nomer.Size = new System.Drawing.Size(43, 38);
            this.mini_nomer.TabIndex = 3;
            // 
            // bron_button
            // 
            this.bron_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.bron_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bron_button.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bron_button.Location = new System.Drawing.Point(102, 376);
            this.bron_button.Name = "bron_button";
            this.bron_button.Size = new System.Drawing.Size(147, 50);
            this.bron_button.TabIndex = 4;
            this.bron_button.Text = "to book";
            this.bron_button.UseVisualStyleBackColor = false;
            this.bron_button.Click += new System.EventHandler(this.bron_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.close_miniForm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mini_days);
            this.panel1.Controls.Add(this.bron_button);
            this.panel1.Controls.Add(this.mini_data);
            this.panel1.Controls.Add(this.mini_nomer);
            this.panel1.Controls.Add(this.mini_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 512);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bronhotel2.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(561, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(196, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 56);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "booking a room";
            // 
            // close_miniForm
            // 
            this.close_miniForm.AutoSize = true;
            this.close_miniForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_miniForm.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_miniForm.Location = new System.Drawing.Point(665, 0);
            this.close_miniForm.Name = "close_miniForm";
            this.close_miniForm.Size = new System.Drawing.Size(39, 54);
            this.close_miniForm.TabIndex = 13;
            this.close_miniForm.Text = "x";
            this.close_miniForm.Click += new System.EventHandler(this.close_miniForm_Click);
            this.close_miniForm.MouseEnter += new System.EventHandler(this.close_miniForm_MouseEnter);
            this.close_miniForm.MouseLeave += new System.EventHandler(this.close_miniForm_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "ваш номер..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "введите количество дней..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "введите дату бронирования..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "введите свой логин..";
            // 
            // mini_name
            // 
            this.mini_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            this.mini_name.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mini_name.Location = new System.Drawing.Point(34, 200);
            this.mini_name.Name = "mini_name";
            this.mini_name.Size = new System.Drawing.Size(125, 38);
            this.mini_name.TabIndex = 0;
            // 
            // miniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "miniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "miniForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox mini_data;
        private System.Windows.Forms.TextBox mini_days;
        private System.Windows.Forms.TextBox mini_nomer;
        private System.Windows.Forms.Button bron_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label close_miniForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mini_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}