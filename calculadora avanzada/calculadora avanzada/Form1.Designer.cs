namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdIgual = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdMult = new System.Windows.Forms.Button();
            this.cmdResta = new System.Windows.Forms.Button();
            this.cmdSuma = new System.Windows.Forms.Button();
            this.cmdLimp = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.cmdPunto = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(66, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 41;
            this.lblResult.Text = "0";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Location = new System.Drawing.Point(66, 14);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(13, 13);
            this.lblOper.TabIndex = 40;
            this.lblOper.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 51);
            this.textBox1.TabIndex = 39;
            // 
            // cmdIgual
            // 
            this.cmdIgual.Location = new System.Drawing.Point(187, 222);
            this.cmdIgual.Name = "cmdIgual";
            this.cmdIgual.Size = new System.Drawing.Size(40, 29);
            this.cmdIgual.TabIndex = 37;
            this.cmdIgual.Text = "=";
            this.cmdIgual.UseVisualStyleBackColor = true;
            this.cmdIgual.Click += new System.EventHandler(this.cmdIgual_Click_1);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(187, 187);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(40, 33);
            this.cmdDiv.TabIndex = 38;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            // 
            // cmdMult
            // 
            this.cmdMult.Location = new System.Drawing.Point(186, 151);
            this.cmdMult.Name = "cmdMult";
            this.cmdMult.Size = new System.Drawing.Size(40, 33);
            this.cmdMult.TabIndex = 36;
            this.cmdMult.Text = "*";
            this.cmdMult.UseVisualStyleBackColor = true;
            // 
            // cmdResta
            // 
            this.cmdResta.Location = new System.Drawing.Point(187, 112);
            this.cmdResta.Name = "cmdResta";
            this.cmdResta.Size = new System.Drawing.Size(40, 33);
            this.cmdResta.TabIndex = 35;
            this.cmdResta.Text = "-";
            this.cmdResta.UseVisualStyleBackColor = true;
            // 
            // cmdSuma
            // 
            this.cmdSuma.Location = new System.Drawing.Point(187, 78);
            this.cmdSuma.Name = "cmdSuma";
            this.cmdSuma.Size = new System.Drawing.Size(40, 33);
            this.cmdSuma.TabIndex = 34;
            this.cmdSuma.Text = "+";
            this.cmdSuma.UseVisualStyleBackColor = true;
            // 
            // cmdLimp
            // 
            this.cmdLimp.Location = new System.Drawing.Point(116, 78);
            this.cmdLimp.Name = "cmdLimp";
            this.cmdLimp.Size = new System.Drawing.Size(65, 25);
            this.cmdLimp.TabIndex = 32;
            this.cmdLimp.Text = "c";
            this.cmdLimp.UseVisualStyleBackColor = true;
            this.cmdLimp.Click += new System.EventHandler(this.cmdLimp_Click_1);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(58, 78);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 26);
            this.button18.TabIndex = 31;
            this.button18.Text = "<--";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // cmdPunto
            // 
            this.cmdPunto.Location = new System.Drawing.Point(119, 226);
            this.cmdPunto.Name = "cmdPunto";
            this.cmdPunto.Size = new System.Drawing.Size(65, 25);
            this.cmdPunto.TabIndex = 33;
            this.cmdPunto.Text = ".";
            this.cmdPunto.UseVisualStyleBackColor = true;
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(58, 226);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(55, 26);
            this.cmd0.TabIndex = 30;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(144, 187);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(40, 33);
            this.cmd9.TabIndex = 29;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(101, 187);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(40, 33);
            this.cmd8.TabIndex = 28;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(58, 187);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(40, 33);
            this.cmd7.TabIndex = 27;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(143, 149);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(40, 33);
            this.cmd6.TabIndex = 26;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(101, 149);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(40, 33);
            this.cmd5.TabIndex = 25;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(58, 149);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(40, 33);
            this.cmd4.TabIndex = 24;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(144, 110);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(40, 33);
            this.cmd3.TabIndex = 23;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(100, 110);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(40, 33);
            this.cmd2.TabIndex = 22;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(58, 110);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(40, 33);
            this.cmd1.TabIndex = 21;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdIgual);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMult);
            this.Controls.Add(this.cmdResta);
            this.Controls.Add(this.cmdSuma);
            this.Controls.Add(this.cmdLimp);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.cmdPunto);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdIgual;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdResta;
        private System.Windows.Forms.Button cmdSuma;
        private System.Windows.Forms.Button cmdLimp;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button cmdPunto;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd1;
    }
}

