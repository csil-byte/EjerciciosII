
namespace WindowsFormsApp1
{
    partial class Formsitou
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
            this.buttonSaludo = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaludo
            // 
            this.buttonSaludo.Location = new System.Drawing.Point(260, 125);
            this.buttonSaludo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaludo.Name = "buttonSaludo";
            this.buttonSaludo.Size = new System.Drawing.Size(350, 80);
            this.buttonSaludo.TabIndex = 0;
            this.buttonSaludo.Text = "Saludar";
            this.buttonSaludo.UseVisualStyleBackColor = true;
            this.buttonSaludo.Click += new System.EventHandler(this.Saludar_OnClick);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(260, 61);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(350, 56);
            this.textNombre.TabIndex = 1;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombre.TextChanged += new System.EventHandler(this.NombreBox_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(391, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(99, 39);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Formsitou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(892, 257);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.buttonSaludo);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Formsitou";
            this.Text = "Formsitou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaludo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
    }
}