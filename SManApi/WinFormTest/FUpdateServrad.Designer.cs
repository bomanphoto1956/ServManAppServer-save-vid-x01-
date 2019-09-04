namespace WinFormTest
{
    partial class FUpdateServrad
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
            this.tBAnvID = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.lblIdent = new System.Windows.Forms.Label();
            this.dgvServHuv = new System.Windows.Forms.DataGridView();
            this.dgvServRow = new System.Windows.Forms.DataGridView();
            this.dgvServRowEdit = new System.Windows.Forms.DataGridView();
            this.tbKontroll = new System.Windows.Forms.TextBox();
            this.tbArbete = new System.Windows.Forms.TextBox();
            this.tbAnmarkning = new System.Windows.Forms.TextBox();
            this.tbReservdelar = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServHuv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServRowEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tBAnvID
            // 
            this.tBAnvID.Location = new System.Drawing.Point(16, 30);
            this.tBAnvID.Name = "tBAnvID";
            this.tBAnvID.Size = new System.Drawing.Size(100, 20);
            this.tBAnvID.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(13, 53);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Password";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(16, 69);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(100, 20);
            this.tbPwd.TabIndex = 3;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(16, 118);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Location = new System.Drawing.Point(13, 102);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(0, 13);
            this.lblIdent.TabIndex = 5;
            // 
            // dgvServHuv
            // 
            this.dgvServHuv.AllowUserToAddRows = false;
            this.dgvServHuv.AllowUserToDeleteRows = false;
            this.dgvServHuv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServHuv.Location = new System.Drawing.Point(157, 12);
            this.dgvServHuv.MultiSelect = false;
            this.dgvServHuv.Name = "dgvServHuv";
            this.dgvServHuv.ReadOnly = true;
            this.dgvServHuv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServHuv.Size = new System.Drawing.Size(769, 150);
            this.dgvServHuv.TabIndex = 6;
            this.dgvServHuv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServHuv_RowEnter);
            // 
            // dgvServRow
            // 
            this.dgvServRow.AllowUserToAddRows = false;
            this.dgvServRow.AllowUserToDeleteRows = false;
            this.dgvServRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServRow.Location = new System.Drawing.Point(157, 168);
            this.dgvServRow.MultiSelect = false;
            this.dgvServRow.Name = "dgvServRow";
            this.dgvServRow.ReadOnly = true;
            this.dgvServRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServRow.Size = new System.Drawing.Size(769, 150);
            this.dgvServRow.TabIndex = 7;
            this.dgvServRow.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServRow_RowEnter);
            // 
            // dgvServRowEdit
            // 
            this.dgvServRowEdit.AllowUserToAddRows = false;
            this.dgvServRowEdit.AllowUserToDeleteRows = false;
            this.dgvServRowEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServRowEdit.Location = new System.Drawing.Point(157, 336);
            this.dgvServRowEdit.Name = "dgvServRowEdit";
            this.dgvServRowEdit.ReadOnly = true;
            this.dgvServRowEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServRowEdit.Size = new System.Drawing.Size(769, 150);
            this.dgvServRowEdit.TabIndex = 8;
            // 
            // tbKontroll
            // 
            this.tbKontroll.Location = new System.Drawing.Point(157, 506);
            this.tbKontroll.Multiline = true;
            this.tbKontroll.Name = "tbKontroll";
            this.tbKontroll.Size = new System.Drawing.Size(175, 128);
            this.tbKontroll.TabIndex = 9;
            // 
            // tbArbete
            // 
            this.tbArbete.Location = new System.Drawing.Point(338, 506);
            this.tbArbete.Multiline = true;
            this.tbArbete.Name = "tbArbete";
            this.tbArbete.Size = new System.Drawing.Size(175, 128);
            this.tbArbete.TabIndex = 10;
            // 
            // tbAnmarkning
            // 
            this.tbAnmarkning.Location = new System.Drawing.Point(519, 506);
            this.tbAnmarkning.Multiline = true;
            this.tbAnmarkning.Name = "tbAnmarkning";
            this.tbAnmarkning.Size = new System.Drawing.Size(175, 128);
            this.tbAnmarkning.TabIndex = 11;
            // 
            // tbReservdelar
            // 
            this.tbReservdelar.Location = new System.Drawing.Point(700, 506);
            this.tbReservdelar.Multiline = true;
            this.tbReservdelar.Name = "tbReservdelar";
            this.tbReservdelar.Size = new System.Drawing.Size(175, 128);
            this.tbReservdelar.TabIndex = 12;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(882, 605);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 13;
            this.bUpdate.Text = "Uppdatera";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(27, 435);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 14;
            this.bNew.Text = "Ny";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // FUpdateServrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 671);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.tbReservdelar);
            this.Controls.Add(this.tbAnmarkning);
            this.Controls.Add(this.tbArbete);
            this.Controls.Add(this.tbKontroll);
            this.Controls.Add(this.dgvServRowEdit);
            this.Controls.Add(this.dgvServRow);
            this.Controls.Add(this.dgvServHuv);
            this.Controls.Add(this.lblIdent);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.tBAnvID);
            this.Controls.Add(this.label1);
            this.Name = "FUpdateServrad";
            this.Text = "Uppdatera serverrrad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServHuv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServRowEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAnvID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.DataGridView dgvServHuv;
        private System.Windows.Forms.DataGridView dgvServRow;
        private System.Windows.Forms.DataGridView dgvServRowEdit;
        private System.Windows.Forms.TextBox tbKontroll;
        private System.Windows.Forms.TextBox tbArbete;
        private System.Windows.Forms.TextBox tbAnmarkning;
        private System.Windows.Forms.TextBox tbReservdelar;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bNew;
    }
}