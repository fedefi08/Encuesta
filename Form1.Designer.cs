namespace Encuesta
{
    partial class Encuesta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encuesta));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.rbtMayor = new System.Windows.Forms.RadioButton();
            this.rbtMediano = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbEdad = new System.Windows.Forms.GroupBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.grbEstudios = new System.Windows.Forms.GroupBox();
            this.rbtPrimaria = new System.Windows.Forms.RadioButton();
            this.rbtSecundaria = new System.Windows.Forms.RadioButton();
            this.rbtUniversidad = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.grbEdad.SuspendLayout();
            this.grbSexo.SuspendLayout();
            this.grbEstudios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encuesta";
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.Location = new System.Drawing.Point(6, 38);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(97, 20);
            this.rbtMenor.TabIndex = 1;
            this.rbtMenor.TabStop = true;
            this.rbtMenor.Text = "Entre 8 a 20";
            this.rbtMenor.UseVisualStyleBackColor = true;
            this.rbtMenor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.Location = new System.Drawing.Point(293, 38);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(115, 20);
            this.rbtMayor.TabIndex = 3;
            this.rbtMayor.TabStop = true;
            this.rbtMayor.Text = "De 45 a mayor";
            this.rbtMayor.UseVisualStyleBackColor = true;
            // 
            // rbtMediano
            // 
            this.rbtMediano.AutoSize = true;
            this.rbtMediano.Location = new System.Drawing.Point(154, 38);
            this.rbtMediano.Name = "rbtMediano";
            this.rbtMediano.Size = new System.Drawing.Size(104, 20);
            this.rbtMediano.TabIndex = 4;
            this.rbtMediano.TabStop = true;
            this.rbtMediano.Text = "Entre 21 a 45";
            this.rbtMediano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Elegir mejor etapa:";
            // 
            // grbEdad
            // 
            this.grbEdad.Controls.Add(this.rbtMenor);
            this.grbEdad.Controls.Add(this.rbtMediano);
            this.grbEdad.Controls.Add(this.rbtMayor);
            this.grbEdad.Location = new System.Drawing.Point(319, 107);
            this.grbEdad.Name = "grbEdad";
            this.grbEdad.Size = new System.Drawing.Size(418, 74);
            this.grbEdad.TabIndex = 12;
            this.grbEdad.TabStop = false;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbtMasculino);
            this.grbSexo.Controls.Add(this.rbtFemenino);
            this.grbSexo.Location = new System.Drawing.Point(319, 188);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(279, 74);
            this.grbSexo.TabIndex = 13;
            this.grbSexo.TabStop = false;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 38);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(154, 38);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(88, 20);
            this.rbtFemenino.TabIndex = 4;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // grbEstudios
            // 
            this.grbEstudios.Controls.Add(this.rbtPrimaria);
            this.grbEstudios.Controls.Add(this.rbtSecundaria);
            this.grbEstudios.Controls.Add(this.rbtUniversidad);
            this.grbEstudios.Location = new System.Drawing.Point(319, 288);
            this.grbEstudios.Name = "grbEstudios";
            this.grbEstudios.Size = new System.Drawing.Size(418, 74);
            this.grbEstudios.TabIndex = 13;
            this.grbEstudios.TabStop = false;
            // 
            // rbtPrimaria
            // 
            this.rbtPrimaria.AutoSize = true;
            this.rbtPrimaria.Location = new System.Drawing.Point(6, 38);
            this.rbtPrimaria.Name = "rbtPrimaria";
            this.rbtPrimaria.Size = new System.Drawing.Size(78, 20);
            this.rbtPrimaria.TabIndex = 1;
            this.rbtPrimaria.TabStop = true;
            this.rbtPrimaria.Text = "Primaria";
            this.rbtPrimaria.UseVisualStyleBackColor = true;
            // 
            // rbtSecundaria
            // 
            this.rbtSecundaria.AutoSize = true;
            this.rbtSecundaria.Location = new System.Drawing.Point(154, 38);
            this.rbtSecundaria.Name = "rbtSecundaria";
            this.rbtSecundaria.Size = new System.Drawing.Size(97, 20);
            this.rbtSecundaria.TabIndex = 4;
            this.rbtSecundaria.TabStop = true;
            this.rbtSecundaria.Text = "Secundaria";
            this.rbtSecundaria.UseVisualStyleBackColor = true;
            // 
            // rbtUniversidad
            // 
            this.rbtUniversidad.AutoSize = true;
            this.rbtUniversidad.Location = new System.Drawing.Point(293, 38);
            this.rbtUniversidad.Name = "rbtUniversidad";
            this.rbtUniversidad.Size = new System.Drawing.Size(101, 20);
            this.rbtUniversidad.TabIndex = 3;
            this.rbtUniversidad.TabStop = true;
            this.rbtUniversidad.Text = "Universidad";
            this.rbtUniversidad.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(319, 390);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(242, 63);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 589);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grbEstudios);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.grbEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuesta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbEdad.ResumeLayout(false);
            this.grbEdad.PerformLayout();
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbEstudios.ResumeLayout(false);
            this.grbEstudios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.RadioButton rbtMayor;
        private System.Windows.Forms.RadioButton rbtMediano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbEdad;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.GroupBox grbEstudios;
        private System.Windows.Forms.RadioButton rbtPrimaria;
        private System.Windows.Forms.RadioButton rbtSecundaria;
        private System.Windows.Forms.RadioButton rbtUniversidad;
        private System.Windows.Forms.Button btnEnviar;
    }
}

