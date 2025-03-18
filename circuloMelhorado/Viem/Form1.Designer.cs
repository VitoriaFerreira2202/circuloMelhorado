namespace circuloMelhorado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorRaio = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValorRaio
            // 
            this.lblValorRaio.AutoSize = true;
            this.lblValorRaio.Location = new System.Drawing.Point(91, 46);
            this.lblValorRaio.Name = "lblValorRaio";
            this.lblValorRaio.Size = new System.Drawing.Size(144, 13);
            this.lblValorRaio.TabIndex = 0;
            this.lblValorRaio.Text = "DIGITE O VALOR DO RAIO:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(260, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(295, 81);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRestado
            // 
            this.lblRestado.AutoSize = true;
            this.lblRestado.Location = new System.Drawing.Point(157, 112);
            this.lblRestado.Name = "lblRestado";
            this.lblRestado.Size = new System.Drawing.Size(35, 13);
            this.lblRestado.TabIndex = 3;
            this.lblRestado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.lblRestado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValorRaio);
            this.Name = "Form1";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorRaio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRestado;
    }
}

