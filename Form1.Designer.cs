
namespace PesoIdeal
{
    partial class CalculaPesoIdeal
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
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.gpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSexo
            // 
            this.gpSexo.Controls.Add(this.rbtnFem);
            this.gpSexo.Controls.Add(this.rbtnMasc);
            this.gpSexo.Location = new System.Drawing.Point(24, 12);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(220, 52);
            this.gpSexo.TabIndex = 0;
            this.gpSexo.TabStop = false;
            this.gpSexo.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(117, 22);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(75, 19);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            this.rbtnFem.CheckedChanged += new System.EventHandler(this.rbtnFem_CheckedChanged);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(17, 23);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasc.TabIndex = 0;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            this.rbtnMasc.CheckedChanged += new System.EventHandler(this.rbtnMasc_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(266, 12);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(268, 33);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso Ideal";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.lblPesoIdeal.Location = new System.Drawing.Point(129, 88);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(106, 28);
            this.lblPesoIdeal.TabIndex = 4;
            this.lblPesoIdeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculaPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 128);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gpSexo);
            this.Name = "CalculaPesoIdeal";
            this.Text = "Cálculo do Peso Ideal";
            this.Load += new System.EventHandler(this.CalculaPesoIdeal_Load);
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSexo;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPesoIdeal;
    }
}

