namespace HomeWork_4_TPL
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_whence = new System.Windows.Forms.TextBox();
            this.tb_where = new System.Windows.Forms.TextBox();
            this.btn_whence = new System.Windows.Forms.Button();
            this.btn_where = new System.Windows.Forms.Button();
            this.prg_main = new System.Windows.Forms.ProgressBar();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_whence_folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Куда";
            // 
            // tb_whence
            // 
            this.tb_whence.Location = new System.Drawing.Point(106, 30);
            this.tb_whence.Name = "tb_whence";
            this.tb_whence.Size = new System.Drawing.Size(313, 20);
            this.tb_whence.TabIndex = 2;
            // 
            // tb_where
            // 
            this.tb_where.Location = new System.Drawing.Point(106, 77);
            this.tb_where.Name = "tb_where";
            this.tb_where.Size = new System.Drawing.Size(313, 20);
            this.tb_where.TabIndex = 3;
            // 
            // btn_whence
            // 
            this.btn_whence.Location = new System.Drawing.Point(428, 28);
            this.btn_whence.Name = "btn_whence";
            this.btn_whence.Size = new System.Drawing.Size(75, 23);
            this.btn_whence.TabIndex = 4;
            this.btn_whence.Text = "Файл...";
            this.btn_whence.UseVisualStyleBackColor = true;
            this.btn_whence.Click += new System.EventHandler(this.btn_whence_Click);
            // 
            // btn_where
            // 
            this.btn_where.Location = new System.Drawing.Point(428, 75);
            this.btn_where.Name = "btn_where";
            this.btn_where.Size = new System.Drawing.Size(153, 23);
            this.btn_where.TabIndex = 5;
            this.btn_where.Text = "Файл...";
            this.btn_where.UseVisualStyleBackColor = true;
            this.btn_where.Click += new System.EventHandler(this.btn_where_Click);
            // 
            // prg_main
            // 
            this.prg_main.Location = new System.Drawing.Point(16, 124);
            this.prg_main.Name = "prg_main";
            this.prg_main.Size = new System.Drawing.Size(403, 22);
            this.prg_main.Step = 1;
            this.prg_main.TabIndex = 6;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(428, 124);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(153, 23);
            this.btn_copy.TabIndex = 7;
            this.btn_copy.Text = "Копировать";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_whence_folder
            // 
            this.btn_whence_folder.Location = new System.Drawing.Point(509, 28);
            this.btn_whence_folder.Name = "btn_whence_folder";
            this.btn_whence_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_whence_folder.TabIndex = 8;
            this.btn_whence_folder.Text = "Папка...";
            this.btn_whence_folder.UseVisualStyleBackColor = true;
            this.btn_whence_folder.Click += new System.EventHandler(this.btn_whence_folder_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 175);
            this.Controls.Add(this.btn_whence_folder);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.prg_main);
            this.Controls.Add(this.btn_where);
            this.Controls.Add(this.btn_whence);
            this.Controls.Add(this.tb_where);
            this.Controls.Add(this.tb_whence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Копирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_whence;
        private System.Windows.Forms.TextBox tb_where;
        private System.Windows.Forms.Button btn_whence;
        private System.Windows.Forms.Button btn_where;
        private System.Windows.Forms.ProgressBar prg_main;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_whence_folder;
    }
}

