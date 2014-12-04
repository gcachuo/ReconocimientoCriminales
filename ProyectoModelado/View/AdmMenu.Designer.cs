namespace ProyectoModelado.View
{
    partial class AdmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmMenu));
            this.btnAgregarCriminal = new System.Windows.Forms.Button();
            this.btnVerCriminales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCriminal
            // 
            this.btnAgregarCriminal.BackColor = System.Drawing.Color.White;
            this.btnAgregarCriminal.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCriminal.Location = new System.Drawing.Point(12, 49);
            this.btnAgregarCriminal.Name = "btnAgregarCriminal";
            this.btnAgregarCriminal.Size = new System.Drawing.Size(213, 47);
            this.btnAgregarCriminal.TabIndex = 0;
            this.btnAgregarCriminal.Text = "Agregar Nuevo Criminal";
            this.btnAgregarCriminal.UseVisualStyleBackColor = false;
            this.btnAgregarCriminal.Click += new System.EventHandler(this.btnAgregarCriminal_Click);
            // 
            // btnVerCriminales
            // 
            this.btnVerCriminales.BackColor = System.Drawing.Color.White;
            this.btnVerCriminales.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCriminales.Location = new System.Drawing.Point(12, 175);
            this.btnVerCriminales.Name = "btnVerCriminales";
            this.btnVerCriminales.Size = new System.Drawing.Size(213, 47);
            this.btnVerCriminales.TabIndex = 1;
            this.btnVerCriminales.Text = "Ver Criminales";
            this.btnVerCriminales.UseVisualStyleBackColor = false;
            this.btnVerCriminales.Click += new System.EventHandler(this.btnVerCriminales_Click);
            // 
            // AdmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(241, 291);
            this.Controls.Add(this.btnVerCriminales);
            this.Controls.Add(this.btnAgregarCriminal);
            this.Name = "AdmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCriminal;
        private System.Windows.Forms.Button btnVerCriminales;
    }
}