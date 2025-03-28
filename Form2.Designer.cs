namespace WindowsFormsApp1_IsabellieDaviOkano
{
    partial class frmmedia
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
            this.lblnota = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(73, 134);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(198, 19);
            this.lblnota.TabIndex = 1;
            this.lblnota.Text = "Digite a nota dos alunos:";
            this.lblnota.Click += new System.EventHandler(this.lblnums_Click);
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedia.Location = new System.Drawing.Point(73, 197);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(176, 19);
            this.lblmedia.TabIndex = 2;
            this.lblmedia.Text = "A média dos alunos é:";
            this.lblmedia.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(287, 133);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 3;
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(287, 196);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 20);
            this.txtmedia.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(93, 299);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 31);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(441, 299);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(96, 31);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(261, 299);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 31);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(602, 299);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(83, 31);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmmedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lblnota);
            this.Name = "frmmedia";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnvoltar;
    }
}