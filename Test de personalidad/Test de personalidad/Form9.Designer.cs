namespace Test_de_personalidad
{
    partial class Form9
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
            this.rB7 = new System.Windows.Forms.RadioButton();
            this.btnSig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "8. ¿Cuál de los siguientes colores le gusta más?\r\n";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(220, 57);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(124, 17);
            this.rB1.TabIndex = 1;
            this.rB1.Text = "a) Rojo o anaranjado";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(220, 106);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(64, 17);
            this.rB2.TabIndex = 2;
            this.rB2.Text = "b) negro";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(220, 148);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(118, 17);
            this.rB3.TabIndex = 3;
            this.rB3.Text = "c) amarillo o celeste";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(220, 191);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(64, 17);
            this.rB4.TabIndex = 4;
            this.rB4.Text = "d) verde";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.RB4_CheckedChanged);
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(220, 228);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(106, 17);
            this.rB5.TabIndex = 5;
            this.rB5.Text = "e) azul o morado ";
            this.rB5.UseVisualStyleBackColor = true;
            this.rB5.CheckedChanged += new System.EventHandler(this.RB5_CheckedChanged);
            // 
            // rB6
            // 
            this.rB6.AutoSize = true;
            this.rB6.Location = new System.Drawing.Point(220, 264);
            this.rB6.Name = "rB6";
            this.rB6.Size = new System.Drawing.Size(69, 17);
            this.rB6.TabIndex = 6;
            this.rB6.Text = "f) blanco ";
            this.rB6.UseVisualStyleBackColor = true;
            this.rB6.CheckedChanged += new System.EventHandler(this.RB6_CheckedChanged);
            // 
            // rB7
            // 
            this.rB7.AutoSize = true;
            this.rB7.Location = new System.Drawing.Point(220, 302);
            this.rB7.Name = "rB7";
            this.rB7.Size = new System.Drawing.Size(97, 17);
            this.rB7.TabIndex = 7;
            this.rB7.Text = "g) marrón o gris";
            this.rB7.UseVisualStyleBackColor = true;
            this.rB7.CheckedChanged += new System.EventHandler(this.RadioButton7_CheckedChanged);
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(220, 337);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(149, 23);
            this.btnSig.TabIndex = 8;
            this.btnSig.Text = "Siguiente pregunta";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.BtnSig_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.rB7);
            this.Controls.Add(this.rB6);
            this.Controls.Add(this.rB5);
            this.Controls.Add(this.rB4);
            this.Controls.Add(this.rB3);
            this.Controls.Add(this.rB2);
            this.Controls.Add(this.rB1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
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
        private System.Windows.Forms.RadioButton rB7;
        private System.Windows.Forms.Button btnSig;
    }
}