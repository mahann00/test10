namespace calculator
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
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtnumber2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول:";
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(53, 159);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 23);
            this.btnplus.TabIndex = 1;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(169, 159);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 23);
            this.btnminus.TabIndex = 2;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiple
            // 
            this.btnmultiple.Location = new System.Drawing.Point(279, 159);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(75, 23);
            this.btnmultiple.TabIndex = 3;
            this.btnmultiple.Text = "*";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btndivid
            // 
            this.btndivid.Location = new System.Drawing.Point(378, 159);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(75, 23);
            this.btndivid.TabIndex = 4;
            this.btndivid.Text = "/";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.btndivid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "عدد دوم:";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(291, 41);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(120, 21);
            this.txtnumber1.TabIndex = 8;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(291, 72);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(120, 21);
            this.txtnumber2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 383);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndivid);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب :";
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btndivid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtnumber1;
        private System.Windows.Forms.NumericUpDown txtnumber2;
    }
}

