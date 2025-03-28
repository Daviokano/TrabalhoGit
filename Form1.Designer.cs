namespace WindowsFormsApp1_IsabellieDaviOkano
{
    partial class frmnotas
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
            this.lblnums = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnums
            // 
            this.lblnums.AutoSize = true;
            this.lblnums.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnums.Location = new System.Drawing.Point(50, 166);
            this.lblnums.Name = "lblnums";
            this.lblnums.Size = new System.Drawing.Size(186, 19);
            this.lblnums.TabIndex = 0;
            this.lblnums.Text = "Os números pares são:";
            this.lblnums.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(268, 151);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumber.Size = new System.Drawing.Size(100, 62);
            this.txtNumber.TabIndex = 1;
            // 
            // btnApresentar
            // 
            this.btnApresentar.Location = new System.Drawing.Point(280, 219);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(75, 45);
            this.btnApresentar.TabIndex = 2;
            this.btnApresentar.Text = "Mostrar os números:";
            this.btnApresentar.UseVisualStyleBackColor = true;
            this.btnApresentar.Click += new System.EventHandler(this.btnApresentar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(338, 317);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(83, 31);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmnotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnApresentar);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblnums);
            this.Name = "frmnotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnums;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnApresentar;
        private System.Windows.Forms.Button btnvoltar;
    }
}

