namespace Atividade
{
    partial class EX7
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
            this.btnDesc = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.Bisque;
            this.btnDesc.Location = new System.Drawing.Point(89, 78);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(130, 39);
            this.btnDesc.TabIndex = 0;
            this.btnDesc.Text = "Descobrir";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta.Location = new System.Drawing.Point(6, 138);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(2, 15);
            this.lblResposta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arlindo tem 1,50m e cresce 2 centímetros por ano, \r\nenquanto Manoel tem 1,10m e c" +
                "resce 3 centímetros por ano. \r\nQuantos anos serão necessários para que Manoel \r\n" +
                "seja maior que Arlindo?";
            // 
            // EX7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnDesc);
            this.Name = "EX7";
            this.Text = "EX7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label1;

    }
}