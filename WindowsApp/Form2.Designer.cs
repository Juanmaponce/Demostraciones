namespace WindowsApp
{
    partial class FormNotas
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnMaxNota = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(42, 23);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 13);
            this.lblNotas.TabIndex = 0;
            this.lblNotas.Text = "Notas:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(130, 23);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(130, 67);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(130, 116);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 3;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(130, 167);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 4;
            // 
            // btnMaxNota
            // 
            this.btnMaxNota.Location = new System.Drawing.Point(130, 249);
            this.btnMaxNota.Name = "btnMaxNota";
            this.btnMaxNota.Size = new System.Drawing.Size(125, 23);
            this.btnMaxNota.TabIndex = 5;
            this.btnMaxNota.Text = "Mostrar Mayor Nota ";
            this.btnMaxNota.UseVisualStyleBackColor = true;
            this.btnMaxNota.Click += new System.EventHandler(this.btnMaxNota_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(130, 300);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(125, 23);
            this.btnPromedio.TabIndex = 6;
            this.btnPromedio.Text = "Mostrar Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnMaxNota);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNotas);
            this.Name = "FormNotas";
            this.Text = "FormNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btnMaxNota;
        private System.Windows.Forms.Button btnPromedio;
    }
}