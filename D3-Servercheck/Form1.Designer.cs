namespace D3_Servercheck
{
    partial class startForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipOutput
            // 
            this.ipOutput.Location = new System.Drawing.Point(12, 9);
            this.ipOutput.Name = "ipOutput";
            this.ipOutput.Size = new System.Drawing.Size(260, 178);
            this.ipOutput.TabIndex = 1;
            this.ipOutput.Text = "ServerIP";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ipOutput);
            this.Name = "startForm";
            this.Text = "D3 Servercheck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ipOutput;
    }
}

