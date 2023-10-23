namespace fordongusu4_1504
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
            this.btnyaz = new System.Windows.Forms.Button();
            this.lbsayilar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslanınc = new System.Windows.Forms.TextBox();
            this.txtBıtıs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnyaz
            // 
            this.btnyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyaz.Location = new System.Drawing.Point(15, 287);
            this.btnyaz.Name = "btnyaz";
            this.btnyaz.Size = new System.Drawing.Size(163, 65);
            this.btnyaz.TabIndex = 2;
            this.btnyaz.Text = "yaz";
            this.btnyaz.UseVisualStyleBackColor = true;
            this.btnyaz.Click += new System.EventHandler(this.btnyaz_Click);
            // 
            // lbsayilar
            // 
            this.lbsayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsayilar.FormattingEnabled = true;
            this.lbsayilar.ItemHeight = 24;
            this.lbsayilar.Location = new System.Drawing.Point(221, 12);
            this.lbsayilar.Name = "lbsayilar";
            this.lbsayilar.Size = new System.Drawing.Size(211, 340);
            this.lbsayilar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitiş";
            // 
            // txtBaslanınc
            // 
            this.txtBaslanınc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslanınc.Location = new System.Drawing.Point(15, 39);
            this.txtBaslanınc.Name = "txtBaslanınc";
            this.txtBaslanınc.Size = new System.Drawing.Size(100, 29);
            this.txtBaslanınc.TabIndex = 6;
            // 
            // txtBıtıs
            // 
            this.txtBıtıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBıtıs.Location = new System.Drawing.Point(15, 98);
            this.txtBıtıs.Name = "txtBıtıs";
            this.txtBıtıs.Size = new System.Drawing.Size(100, 29);
            this.txtBıtıs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(524, 479);
            this.Controls.Add(this.txtBıtıs);
            this.Controls.Add(this.txtBaslanınc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbsayilar);
            this.Controls.Add(this.btnyaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyaz;
        private System.Windows.Forms.ListBox lbsayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaslanınc;
        private System.Windows.Forms.TextBox txtBıtıs;
    }
}

