namespace WinFormTest
{
    partial class FVentil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbIDNR = new System.Windows.Forms.TextBox();
            this.tbVentiltyp = new System.Windows.Forms.TextBox();
            this.tbFabrikat = new System.Windows.Forms.TextBox();
            this.tbAnlaggningnr = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbVentilID = new System.Windows.Forms.TextBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.bForce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1211, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ident";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1097, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Spara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID nr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ventiltyp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fabrikat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Anlaggningsnr";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(331, 26);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 20);
            this.tbPosition.TabIndex = 10;
            // 
            // tbIDNR
            // 
            this.tbIDNR.Location = new System.Drawing.Point(446, 27);
            this.tbIDNR.Name = "tbIDNR";
            this.tbIDNR.Size = new System.Drawing.Size(100, 20);
            this.tbIDNR.TabIndex = 11;
            // 
            // tbVentiltyp
            // 
            this.tbVentiltyp.Location = new System.Drawing.Point(552, 26);
            this.tbVentiltyp.Name = "tbVentiltyp";
            this.tbVentiltyp.Size = new System.Drawing.Size(100, 20);
            this.tbVentiltyp.TabIndex = 12;
            // 
            // tbFabrikat
            // 
            this.tbFabrikat.Location = new System.Drawing.Point(677, 27);
            this.tbFabrikat.Name = "tbFabrikat";
            this.tbFabrikat.Size = new System.Drawing.Size(100, 20);
            this.tbFabrikat.TabIndex = 13;
            // 
            // tbAnlaggningnr
            // 
            this.tbAnlaggningnr.Location = new System.Drawing.Point(790, 27);
            this.tbAnlaggningnr.Name = "tbAnlaggningnr";
            this.tbAnlaggningnr.Size = new System.Drawing.Size(100, 20);
            this.tbAnlaggningnr.TabIndex = 14;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(15, 313);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1136, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ny";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbVentilID
            // 
            this.tbVentilID.Location = new System.Drawing.Point(12, 316);
            this.tbVentilID.Name = "tbVentilID";
            this.tbVentilID.Size = new System.Drawing.Size(281, 20);
            this.tbVentilID.TabIndex = 17;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(12, 342);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(568, 20);
            this.tbError.TabIndex = 18;
            // 
            // bForce
            // 
            this.bForce.Location = new System.Drawing.Point(1136, 342);
            this.bForce.Name = "bForce";
            this.bForce.Size = new System.Drawing.Size(75, 23);
            this.bForce.TabIndex = 19;
            this.bForce.Text = "Forced";
            this.bForce.UseVisualStyleBackColor = true;
            this.bForce.Click += new System.EventHandler(this.bForce_Click);
            // 
            // FVentil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 538);
            this.Controls.Add(this.bForce);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.tbVentilID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbAnlaggningnr);
            this.Controls.Add(this.tbFabrikat);
            this.Controls.Add(this.tbVentiltyp);
            this.Controls.Add(this.tbIDNR);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FVentil";
            this.Text = "Ventil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbIDNR;
        private System.Windows.Forms.TextBox tbVentiltyp;
        private System.Windows.Forms.TextBox tbFabrikat;
        private System.Windows.Forms.TextBox tbAnlaggningnr;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbVentilID;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Button bForce;
    }
}