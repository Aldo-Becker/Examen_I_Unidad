namespace Examen_1er_Parcial
{
    partial class Ejercicio3
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
            this.PresionarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PresionarButton
            // 
            this.PresionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresionarButton.Location = new System.Drawing.Point(413, 244);
            this.PresionarButton.Name = "PresionarButton";
            this.PresionarButton.Size = new System.Drawing.Size(120, 49);
            this.PresionarButton.TabIndex = 0;
            this.PresionarButton.Text = "Presionar";
            this.PresionarButton.UseVisualStyleBackColor = true;
            this.PresionarButton.Click += new System.EventHandler(this.PresionarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 537);
            this.listBox1.TabIndex = 1;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PresionarButton);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PresionarButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}