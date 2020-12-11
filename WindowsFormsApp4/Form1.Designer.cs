namespace WindowsFormsApp4
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
            this.btn_proses = new System.Windows.Forms.Button();
            this.lbl_input = new System.Windows.Forms.Label();
            this.tb_pesan = new System.Windows.Forms.TextBox();
            this.lbl_empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(123, 136);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(75, 23);
            this.btn_proses.TabIndex = 0;
            this.btn_proses.Text = "proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(120, 65);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(54, 13);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "input data";
            // 
            // tb_pesan
            // 
            this.tb_pesan.Location = new System.Drawing.Point(123, 99);
            this.tb_pesan.Name = "tb_pesan";
            this.tb_pesan.Size = new System.Drawing.Size(134, 20);
            this.tb_pesan.TabIndex = 2;
            // 
            // lbl_empty
            // 
            this.lbl_empty.AutoSize = true;
            this.lbl_empty.Location = new System.Drawing.Point(120, 180);
            this.lbl_empty.Name = "lbl_empty";
            this.lbl_empty.Size = new System.Drawing.Size(50, 13);
            this.lbl_empty.TabIndex = 3;
            this.lbl_empty.Text = "[EMPTY]";
            this.lbl_empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_empty);
            this.Controls.Add(this.tb_pesan);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.btn_proses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_proses;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox tb_pesan;
        private System.Windows.Forms.Label lbl_empty;
    }
}

