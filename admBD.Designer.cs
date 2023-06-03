using System.Drawing;

namespace bronhotel2
{
    partial class admBD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adm_dataTable = new System.Windows.Forms.DataGridView();
            this.delete_adm_button = new System.Windows.Forms.Button();
            this.delete_id = new System.Windows.Forms.TextBox();
            this.close_admBD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adm_dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // adm_dataTable
            // 
            this.adm_dataTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adm_dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adm_dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adm_dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adm_dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adm_dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adm_dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.adm_dataTable.Location = new System.Drawing.Point(27, 57);
            this.adm_dataTable.Name = "adm_dataTable";
            this.adm_dataTable.ReadOnly = true;
            this.adm_dataTable.RowHeadersWidth = 51;
            this.adm_dataTable.RowTemplate.Height = 24;
            this.adm_dataTable.Size = new System.Drawing.Size(659, 356);
            this.adm_dataTable.TabIndex = 0;
            this.adm_dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adm_dataTable_CellClick);
            // 
            // delete_adm_button
            // 
            this.delete_adm_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.delete_adm_button.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_adm_button.Location = new System.Drawing.Point(262, 445);
            this.delete_adm_button.Name = "delete_adm_button";
            this.delete_adm_button.Size = new System.Drawing.Size(144, 55);
            this.delete_adm_button.TabIndex = 1;
            this.delete_adm_button.Text = "delete";
            this.delete_adm_button.UseVisualStyleBackColor = false;
            this.delete_adm_button.Click += new System.EventHandler(this.delete_adm_button_Click);
            // 
            // delete_id
            // 
            this.delete_id.AllowDrop = true;
            this.delete_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.delete_id.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_id.Location = new System.Drawing.Point(503, 432);
            this.delete_id.Name = "delete_id";
            this.delete_id.Size = new System.Drawing.Size(32, 34);
            this.delete_id.TabIndex = 2;
            // 
            // close_admBD
            // 
            this.close_admBD.AutoSize = true;
            this.close_admBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_admBD.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_admBD.Location = new System.Drawing.Point(647, 0);
            this.close_admBD.Name = "close_admBD";
            this.close_admBD.Size = new System.Drawing.Size(39, 54);
            this.close_admBD.TabIndex = 13;
            this.close_admBD.Text = "x";
            this.close_admBD.Click += new System.EventHandler(this.close_admBD_Click);
            this.close_admBD.MouseEnter += new System.EventHandler(this.close_admBD_MouseEnter);
            this.close_admBD.MouseLeave += new System.EventHandler(this.close_admBD_MouseLeave);
            // 
            // admBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(716, 512);
            this.Controls.Add(this.close_admBD);
            this.Controls.Add(this.delete_id);
            this.Controls.Add(this.delete_adm_button);
            this.Controls.Add(this.adm_dataTable);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admBD";
            ((System.ComponentModel.ISupportInitialize)(this.adm_dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adm_dataTable;
        private System.Windows.Forms.Button delete_adm_button;
        private System.Windows.Forms.TextBox delete_id;
        private System.Windows.Forms.Label close_admBD;
    }
}