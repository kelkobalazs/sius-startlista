namespace startlista
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
            this.label1 = new System.Windows.Forms.Label();
            this.fbd_mappa = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_talloz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_generalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verseny mappája";
            // 
            // btn_talloz
            // 
            this.btn_talloz.Location = new System.Drawing.Point(345, 54);
            this.btn_talloz.Name = "btn_talloz";
            this.btn_talloz.Size = new System.Drawing.Size(75, 23);
            this.btn_talloz.TabIndex = 1;
            this.btn_talloz.Text = "Tallóz";
            this.btn_talloz.UseVisualStyleBackColor = true;
            this.btn_talloz.Click += new System.EventHandler(this.btn_talloz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_generalas
            // 
            this.btn_generalas.Location = new System.Drawing.Point(218, 125);
            this.btn_generalas.Name = "btn_generalas";
            this.btn_generalas.Size = new System.Drawing.Size(75, 23);
            this.btn_generalas.TabIndex = 3;
            this.btn_generalas.Text = "Generálás";
            this.btn_generalas.UseVisualStyleBackColor = true;
            this.btn_generalas.Click += new System.EventHandler(this.btn_generalas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 195);
            this.Controls.Add(this.btn_generalas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_talloz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Startlista generátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbd_mappa;
        private System.Windows.Forms.Button btn_talloz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_generalas;
    }
}

