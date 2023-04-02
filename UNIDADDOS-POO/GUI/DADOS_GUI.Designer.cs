namespace UNIDADDOS_POO.GUI
{
    partial class DADOS_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewLanzamientos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxDado2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanzamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lanzar dados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewLanzamientos
            // 
            this.dataGridViewLanzamientos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLanzamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanzamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewLanzamientos.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewLanzamientos.Location = new System.Drawing.Point(12, 241);
            this.dataGridViewLanzamientos.Name = "dataGridViewLanzamientos";
            this.dataGridViewLanzamientos.Size = new System.Drawing.Size(446, 261);
            this.dataGridViewLanzamientos.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de lanzamiento";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dado 1";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dado 2";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // pictureBoxDado2
            // 
            this.pictureBoxDado2.Image = global::UNIDADDOS_POO.Properties.Resources.dado1;
            this.pictureBoxDado2.Location = new System.Drawing.Point(271, 12);
            this.pictureBoxDado2.Name = "pictureBoxDado2";
            this.pictureBoxDado2.Size = new System.Drawing.Size(187, 161);
            this.pictureBoxDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDado2.TabIndex = 1;
            this.pictureBoxDado2.TabStop = false;
            // 
            // pictureBoxDado1
            // 
            this.pictureBoxDado1.Image = global::UNIDADDOS_POO.Properties.Resources.dado1;
            this.pictureBoxDado1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDado1.Name = "pictureBoxDado1";
            this.pictureBoxDado1.Size = new System.Drawing.Size(187, 161);
            this.pictureBoxDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDado1.TabIndex = 0;
            this.pictureBoxDado1.TabStop = false;
            // 
            // DADOS_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(478, 514);
            this.Controls.Add(this.dataGridViewLanzamientos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxDado2);
            this.Controls.Add(this.pictureBoxDado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DADOS_GUI";
            this.Text = "DADOS_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanzamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDado1;
        private System.Windows.Forms.PictureBox pictureBoxDado2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewLanzamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}