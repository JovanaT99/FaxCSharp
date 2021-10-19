
namespace Projekat1
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonProdaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(24, 26);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(446, 58);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Administracija i statistika";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonProdaja
            // 
            this.buttonProdaja.Location = new System.Drawing.Point(24, 110);
            this.buttonProdaja.Name = "buttonProdaja";
            this.buttonProdaja.Size = new System.Drawing.Size(446, 60);
            this.buttonProdaja.TabIndex = 1;
            this.buttonProdaja.Text = "Prodaja/Naplata";
            this.buttonProdaja.UseVisualStyleBackColor = true;
            this.buttonProdaja.Click += new System.EventHandler(this.buttonProdaja_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 218);
            this.Controls.Add(this.buttonProdaja);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "FormStart";
            this.Text = "Aplikacija za trgovinu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonProdaja;
    }
}

