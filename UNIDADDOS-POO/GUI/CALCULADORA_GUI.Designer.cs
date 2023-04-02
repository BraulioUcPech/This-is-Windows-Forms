namespace UNIDADDOS_POO.GUI
{
    partial class CALCULADORA_GUI
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
            this.lblnumerouno = new System.Windows.Forms.Label();
            this.lblnumerodos = new System.Windows.Forms.Label();
            this.txtnumerouno = new System.Windows.Forms.TextBox();
            this.txtnumerodos = new System.Windows.Forms.TextBox();
            this.gruboxOperacion = new System.Windows.Forms.GroupBox();
            this.rbtnMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtnDividir = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnSumar = new System.Windows.Forms.RadioButton();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gruboxOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumerouno
            // 
            this.lblnumerouno.AutoSize = true;
            this.lblnumerouno.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerouno.Location = new System.Drawing.Point(12, 33);
            this.lblnumerouno.Name = "lblnumerouno";
            this.lblnumerouno.Size = new System.Drawing.Size(145, 35);
            this.lblnumerouno.TabIndex = 0;
            this.lblnumerouno.Text = "Número 1";
            // 
            // lblnumerodos
            // 
            this.lblnumerodos.AutoSize = true;
            this.lblnumerodos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerodos.Location = new System.Drawing.Point(281, 33);
            this.lblnumerodos.Name = "lblnumerodos";
            this.lblnumerodos.Size = new System.Drawing.Size(145, 35);
            this.lblnumerodos.TabIndex = 1;
            this.lblnumerodos.Text = "Número 2";
            // 
            // txtnumerouno
            // 
            this.txtnumerouno.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerouno.Location = new System.Drawing.Point(163, 33);
            this.txtnumerouno.Name = "txtnumerouno";
            this.txtnumerouno.Size = new System.Drawing.Size(100, 38);
            this.txtnumerouno.TabIndex = 2;
            // 
            // txtnumerodos
            // 
            this.txtnumerodos.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodos.Location = new System.Drawing.Point(432, 30);
            this.txtnumerodos.Name = "txtnumerodos";
            this.txtnumerodos.Size = new System.Drawing.Size(100, 38);
            this.txtnumerodos.TabIndex = 3;
            // 
            // gruboxOperacion
            // 
            this.gruboxOperacion.Controls.Add(this.rbtnMultiplicar);
            this.gruboxOperacion.Controls.Add(this.rbtnDividir);
            this.gruboxOperacion.Controls.Add(this.rbtnResta);
            this.gruboxOperacion.Controls.Add(this.rbtnSumar);
            this.gruboxOperacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gruboxOperacion.Location = new System.Drawing.Point(174, 95);
            this.gruboxOperacion.Name = "gruboxOperacion";
            this.gruboxOperacion.Size = new System.Drawing.Size(185, 207);
            this.gruboxOperacion.TabIndex = 4;
            this.gruboxOperacion.TabStop = false;
            this.gruboxOperacion.Text = "OPERACIÓN";
            // 
            // rbtnMultiplicar
            // 
            this.rbtnMultiplicar.AutoSize = true;
            this.rbtnMultiplicar.Location = new System.Drawing.Point(4, 162);
            this.rbtnMultiplicar.Name = "rbtnMultiplicar";
            this.rbtnMultiplicar.Size = new System.Drawing.Size(140, 32);
            this.rbtnMultiplicar.TabIndex = 3;
            this.rbtnMultiplicar.TabStop = true;
            this.rbtnMultiplicar.Text = "Multiplicar";
            this.rbtnMultiplicar.UseVisualStyleBackColor = true;
            this.rbtnMultiplicar.CheckedChanged += new System.EventHandler(this.rbtnMultiplicar_CheckedChanged);
            // 
            // rbtnDividir
            // 
            this.rbtnDividir.AutoSize = true;
            this.rbtnDividir.Location = new System.Drawing.Point(6, 124);
            this.rbtnDividir.Name = "rbtnDividir";
            this.rbtnDividir.Size = new System.Drawing.Size(96, 32);
            this.rbtnDividir.TabIndex = 2;
            this.rbtnDividir.TabStop = true;
            this.rbtnDividir.Text = "Dividir";
            this.rbtnDividir.UseVisualStyleBackColor = true;
            this.rbtnDividir.CheckedChanged += new System.EventHandler(this.rbtnDividir_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(6, 86);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(94, 32);
            this.rbtnResta.TabIndex = 1;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Restar";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.CheckedChanged += new System.EventHandler(this.rbtnResta_CheckedChanged);
            // 
            // rbtnSumar
            // 
            this.rbtnSumar.AutoSize = true;
            this.rbtnSumar.Location = new System.Drawing.Point(6, 48);
            this.rbtnSumar.Name = "rbtnSumar";
            this.rbtnSumar.Size = new System.Drawing.Size(95, 32);
            this.rbtnSumar.TabIndex = 0;
            this.rbtnSumar.TabStop = true;
            this.rbtnSumar.Text = "Sumar";
            this.rbtnSumar.UseVisualStyleBackColor = true;
            this.rbtnSumar.CheckedChanged += new System.EventHandler(this.rbtnSumar_CheckedChanged);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(269, 330);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(231, 38);
            this.txtRespuesta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Respuesta";
            // 
            // CALCULADORA_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.gruboxOperacion);
            this.Controls.Add(this.txtnumerodos);
            this.Controls.Add(this.txtnumerouno);
            this.Controls.Add(this.lblnumerodos);
            this.Controls.Add(this.lblnumerouno);
            this.Name = "CALCULADORA_GUI";
            this.Text = "CALCULADORA_GUI";
            this.gruboxOperacion.ResumeLayout(false);
            this.gruboxOperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumerouno;
        private System.Windows.Forms.Label lblnumerodos;
        private System.Windows.Forms.TextBox txtnumerouno;
        private System.Windows.Forms.TextBox txtnumerodos;
        private System.Windows.Forms.GroupBox gruboxOperacion;
        private System.Windows.Forms.RadioButton rbtnMultiplicar;
        private System.Windows.Forms.RadioButton rbtnDividir;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnSumar;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label1;
    }
}