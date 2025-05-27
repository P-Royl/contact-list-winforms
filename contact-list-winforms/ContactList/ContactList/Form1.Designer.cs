namespace ContactList
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
            this.txt_danhsach = new System.Windows.Forms.Label();
            this.btn_themlienhe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_danhsach
            // 
            this.txt_danhsach.AutoSize = true;
            this.txt_danhsach.Location = new System.Drawing.Point(298, 27);
            this.txt_danhsach.Name = "txt_danhsach";
            this.txt_danhsach.Size = new System.Drawing.Size(122, 16);
            this.txt_danhsach.TabIndex = 0;
            this.txt_danhsach.Text = "Danh Sách Liên Hệ";
            // 
            // btn_themlienhe
            // 
            this.btn_themlienhe.Location = new System.Drawing.Point(86, 110);
            this.btn_themlienhe.Name = "btn_themlienhe";
            this.btn_themlienhe.Size = new System.Drawing.Size(187, 23);
            this.btn_themlienhe.TabIndex = 1;
            this.btn_themlienhe.Text = "Thêm Liên Hệ";
            this.btn_themlienhe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_themlienhe);
            this.Controls.Add(this.txt_danhsach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_danhsach;
        private System.Windows.Forms.Button btn_themlienhe;
    }
}

