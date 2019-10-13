namespace Test_de_personalidad
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.rB6 = new System.Windows.Forms.RadioButton();
            this.btnSig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "10. A menudo Ud. sueña que está...\r\n";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(256, 70);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(78, 17);
            this.rB1.TabIndex = 1;
            this.rB1.Text = "a) cayendo";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(256, 116);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(178, 17);
            this.rB2.TabIndex = 2;
            this.rB2.Text = "b) peleando o luchando por algo";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(256, 160);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(162, 17);
            this.rB3.TabIndex = 3;
            this.rB3.Text = "c) buscando algo o a alguien";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(256, 196);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(125, 17);
            this.rB4.TabIndex = 4;
            this.rB4.Text = "d) volando o flotando";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.RB4_CheckedChanged);
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(256, 239);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(144, 17);
            this.rB5.TabIndex = 5;
            this.rB5.Text = "e) normalmente no sueña";
            this.rB5.UseVisualStyleBackColor = true;
            this.rB5.CheckedChanged += new System.EventHandler(this.RB5_CheckedChanged);
            // 
            // rB6
            // 
            this.rB6.AutoSize = true;
            this.rB6.Location = new System.Drawing.Point(256, 279);
            this.rB6.Name = "rB6";
            this.rB6.Size = new System.Drawing.Size(201, 17);
            this.rB6.TabIndex = 6;
            this.rB6.Text = "f) sus sueños siempre son agradables";
            this.rB6.UseVisualStyleBackColor = true;
            this.rB6.CheckedChanged += new System.EventHandler(this.RB6_CheckedChanged);
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(256, 322);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(113, 23);
            this.btnSig.TabIndex = 7;
            this.btnSig.Text = "Siguiente pregunta";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.BtnSig_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.rB6);
            this.Controls.Add(this.rB5);
            this.Controls.Add(this.rB4);
            this.Controls.Add(this.rB3);
            this.Controls.Add(this.rB2);
            this.Controls.Add(this.rB1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.RadioButton rB6;
        private System.Windows.Forms.Button btnSig;
    }
}