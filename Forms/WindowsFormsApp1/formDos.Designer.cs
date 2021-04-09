
namespace WindowsFormsApp1
{
    partial class formDos
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
            this.labelDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDos
            // 
            this.labelDos.AutoSize = true;
            this.labelDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDos.Location = new System.Drawing.Point(168, 79);
            this.labelDos.Name = "labelDos";
            this.labelDos.Size = new System.Drawing.Size(85, 37);
            this.labelDos.TabIndex = 0;
            this.labelDos.Text = "texto";
            // 
            // formDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 161);
            this.Controls.Add(this.labelDos);
            this.Name = "formDos";
            this.Text = "formDos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDos;
    }
}