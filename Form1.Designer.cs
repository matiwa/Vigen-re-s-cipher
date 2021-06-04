namespace Vigenère_s_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBSource = new System.Windows.Forms.GroupBox();
            this.rBFile = new System.Windows.Forms.RadioButton();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.gBOperation = new System.Windows.Forms.GroupBox();
            this.rBD = new System.Windows.Forms.RadioButton();
            this.rBE = new System.Windows.Forms.RadioButton();
            this.btngo = new System.Windows.Forms.Button();
            this.gBPassword = new System.Windows.Forms.GroupBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.btndraw = new System.Windows.Forms.Button();
            this.tBText = new System.Windows.Forms.TextBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.gBSource.SuspendLayout();
            this.gBOperation.SuspendLayout();
            this.gBPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSource
            // 
            this.gBSource.Controls.Add(this.rBFile);
            this.gBSource.Controls.Add(this.rBText);
            this.gBSource.Location = new System.Drawing.Point(13, 13);
            this.gBSource.Name = "gBSource";
            this.gBSource.Size = new System.Drawing.Size(62, 79);
            this.gBSource.TabIndex = 0;
            this.gBSource.TabStop = false;
            this.gBSource.Text = "Source";
            // 
            // rBFile
            // 
            this.rBFile.AutoSize = true;
            this.rBFile.Location = new System.Drawing.Point(7, 44);
            this.rBFile.Name = "rBFile";
            this.rBFile.Size = new System.Drawing.Size(41, 17);
            this.rBFile.TabIndex = 1;
            this.rBFile.Text = "File";
            this.rBFile.UseVisualStyleBackColor = true;
            this.rBFile.CheckedChanged += new System.EventHandler(this.Selectsource);
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(7, 20);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(46, 17);
            this.rBText.TabIndex = 0;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            this.rBText.CheckedChanged += new System.EventHandler(this.Selectsource);
            // 
            // gBOperation
            // 
            this.gBOperation.Controls.Add(this.rBD);
            this.gBOperation.Controls.Add(this.rBE);
            this.gBOperation.Location = new System.Drawing.Point(82, 13);
            this.gBOperation.Name = "gBOperation";
            this.gBOperation.Size = new System.Drawing.Size(91, 79);
            this.gBOperation.TabIndex = 1;
            this.gBOperation.TabStop = false;
            this.gBOperation.Text = "Operations";
            // 
            // rBD
            // 
            this.rBD.AutoSize = true;
            this.rBD.Location = new System.Drawing.Point(10, 43);
            this.rBD.Name = "rBD";
            this.rBD.Size = new System.Drawing.Size(62, 17);
            this.rBD.TabIndex = 2;
            this.rBD.Text = "Decrypt";
            this.rBD.UseVisualStyleBackColor = true;
            this.rBD.CheckedChanged += new System.EventHandler(this.Operation);
            // 
            // rBE
            // 
            this.rBE.AutoSize = true;
            this.rBE.Checked = true;
            this.rBE.Location = new System.Drawing.Point(10, 20);
            this.rBE.Name = "rBE";
            this.rBE.Size = new System.Drawing.Size(61, 17);
            this.rBE.TabIndex = 1;
            this.rBE.TabStop = true;
            this.rBE.Text = "Encrypt";
            this.rBE.UseVisualStyleBackColor = true;
            this.rBE.CheckedChanged += new System.EventHandler(this.Operation);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(79, 175);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "Encrypt";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.Btngo_Click);
            // 
            // gBPassword
            // 
            this.gBPassword.Controls.Add(this.tBPassword);
            this.gBPassword.Controls.Add(this.btngo);
            this.gBPassword.Controls.Add(this.btndraw);
            this.gBPassword.Location = new System.Drawing.Point(13, 99);
            this.gBPassword.Name = "gBPassword";
            this.gBPassword.Size = new System.Drawing.Size(160, 204);
            this.gBPassword.TabIndex = 2;
            this.gBPassword.TabStop = false;
            this.gBPassword.Text = "Password";
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(7, 20);
            this.tBPassword.Multiline = true;
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(143, 149);
            this.tBPassword.TabIndex = 1;
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(7, 175);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(66, 23);
            this.btndraw.TabIndex = 0;
            this.btndraw.Text = "Draw";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.Btndraw_Click);
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(180, 13);
            this.tBText.Multiline = true;
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(293, 290);
            this.tBText.TabIndex = 3;
            // 
            // tBMessage
            // 
            this.tBMessage.Enabled = false;
            this.tBMessage.Location = new System.Drawing.Point(479, 12);
            this.tBMessage.Multiline = true;
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(293, 290);
            this.tBMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.tBText);
            this.Controls.Add(this.gBPassword);
            this.Controls.Add(this.gBOperation);
            this.Controls.Add(this.gBSource);
            this.Name = "Form1";
            this.Text = "Vigenère\'s cipher";
            this.gBSource.ResumeLayout(false);
            this.gBSource.PerformLayout();
            this.gBOperation.ResumeLayout(false);
            this.gBOperation.PerformLayout();
            this.gBPassword.ResumeLayout(false);
            this.gBPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSource;
        private System.Windows.Forms.RadioButton rBFile;
        private System.Windows.Forms.RadioButton rBText;
        private System.Windows.Forms.GroupBox gBOperation;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.GroupBox gBPassword;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.TextBox tBMessage;
        private System.Windows.Forms.RadioButton rBD;
        private System.Windows.Forms.RadioButton rBE;
    }
}

