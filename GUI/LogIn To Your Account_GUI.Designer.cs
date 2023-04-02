namespace DiseñodeInterfazdeUsuario.GUI
{
    partial class LogIn_To_Your_Account_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_To_Your_Account_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.uI_UserLoginTextBox1 = new UIDC.UI_UserLoginTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uI_UserPasswordTextBox1 = new UIDC.UI_UserPasswordTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.uI_CheckBox1 = new UIDC.UI_CheckBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(152)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn to your Account";
            // 
            // uI_UserLoginTextBox1
            // 
            this.uI_UserLoginTextBox1.BackColor = System.Drawing.Color.White;
            this.uI_UserLoginTextBox1.BackgroundColour = System.Drawing.Color.White;
            this.uI_UserLoginTextBox1.Borde = false;
            this.uI_UserLoginTextBox1.BorderColour = System.Drawing.Color.DodgerBlue;
            this.uI_UserLoginTextBox1.BorderSize = 10;
            this.uI_UserLoginTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.uI_UserLoginTextBox1.Location = new System.Drawing.Point(39, 36);
            this.uI_UserLoginTextBox1.Name = "uI_UserLoginTextBox1";
            this.uI_UserLoginTextBox1.Radio = 12;
            this.uI_UserLoginTextBox1.Size = new System.Drawing.Size(469, 29);
            this.uI_UserLoginTextBox1.TabIndex = 1;
            this.uI_UserLoginTextBox1.Text = "Username";
            this.uI_UserLoginTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uI_UserLoginTextBox1.UseSystemPasswordChar = false;
            this.uI_UserLoginTextBox1.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Black;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uI_UserLoginTextBox1);
            this.panel1.Location = new System.Drawing.Point(-7, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 95);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(155)))), ((int)(((byte)(199)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 95);
            this.panel2.TabIndex = 2;
            // 
            // uI_UserPasswordTextBox1
            // 
            this.uI_UserPasswordTextBox1.BackColor = System.Drawing.Color.White;
            this.uI_UserPasswordTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uI_UserPasswordTextBox1.Borde = false;
            this.uI_UserPasswordTextBox1.BorderColour = System.Drawing.Color.Gray;
            this.uI_UserPasswordTextBox1.BorderSize = 3;
            this.uI_UserPasswordTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.uI_UserPasswordTextBox1.Location = new System.Drawing.Point(32, 247);
            this.uI_UserPasswordTextBox1.Name = "uI_UserPasswordTextBox1";
            this.uI_UserPasswordTextBox1.Radio = 12;
            this.uI_UserPasswordTextBox1.Size = new System.Drawing.Size(469, 29);
            this.uI_UserPasswordTextBox1.TabIndex = 3;
            this.uI_UserPasswordTextBox1.Text = "uI_UserPasswordTextBox1";
            this.uI_UserPasswordTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uI_UserPasswordTextBox1.UseSystemPasswordChar = true;
            this.uI_UserPasswordTextBox1.VisualImage = UIDC.UI_UserPasswordTextBox.Visual.Black;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // uI_CheckBox1
            // 
            this.uI_CheckBox1.AutoSize = true;
            this.uI_CheckBox1.CheckColor = "37, 142, 198";
            this.uI_CheckBox1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_CheckBox1.Location = new System.Drawing.Point(32, 341);
            this.uI_CheckBox1.Name = "uI_CheckBox1";
            this.uI_CheckBox1.Size = new System.Drawing.Size(110, 20);
            this.uI_CheckBox1.TabIndex = 4;
            this.uI_CheckBox1.Text = "Remenber Me";
            this.uI_CheckBox1.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(68)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(195)))), ((int)(((byte)(184)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(68)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(380, 325);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(104, 49);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn_To_Your_Account_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 405);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.uI_CheckBox1);
            this.Controls.Add(this.uI_UserPasswordTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn_To_Your_Account_GUI";
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UIDC.UI_UserLoginTextBox uI_UserLoginTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UIDC.UI_UserPasswordTextBox uI_UserPasswordTextBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private UIDC.UI_CheckBox uI_CheckBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}