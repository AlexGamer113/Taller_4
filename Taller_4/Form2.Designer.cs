namespace Taller_4
{
    partial class frmCrear
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.txtApellidoCrear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsarioCrear = new System.Windows.Forms.TextBox();
            this.txtPasswordCrear = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculion = new System.Windows.Forms.RadioButton();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.Location = new System.Drawing.Point(173, 68);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCrear.TabIndex = 2;
            // 
            // txtApellidoCrear
            // 
            this.txtApellidoCrear.Location = new System.Drawing.Point(173, 106);
            this.txtApellidoCrear.Name = "txtApellidoCrear";
            this.txtApellidoCrear.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoCrear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // txtUsarioCrear
            // 
            this.txtUsarioCrear.Location = new System.Drawing.Point(173, 161);
            this.txtUsarioCrear.Name = "txtUsarioCrear";
            this.txtUsarioCrear.Size = new System.Drawing.Size(100, 22);
            this.txtUsarioCrear.TabIndex = 6;
            // 
            // txtPasswordCrear
            // 
            this.txtPasswordCrear.Location = new System.Drawing.Point(173, 203);
            this.txtPasswordCrear.Name = "txtPasswordCrear";
            this.txtPasswordCrear.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordCrear.TabIndex = 7;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radFemenino);
            this.grpSexo.Controls.Add(this.radMasculion);
            this.grpSexo.Location = new System.Drawing.Point(56, 277);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(200, 100);
            this.grpSexo.TabIndex = 8;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(7, 59);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(88, 20);
            this.radFemenino.TabIndex = 1;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculion
            // 
            this.radMasculion.AutoSize = true;
            this.radMasculion.Location = new System.Drawing.Point(7, 32);
            this.radMasculion.Name = "radMasculion";
            this.radMasculion.Size = new System.Drawing.Size(89, 20);
            this.radMasculion.TabIndex = 0;
            this.radMasculion.TabStop = true;
            this.radMasculion.Text = "Masculino";
            this.radMasculion.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(56, 395);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // frmCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.txtPasswordCrear);
            this.Controls.Add(this.txtUsarioCrear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoCrear);
            this.Controls.Add(this.txtNombreCrear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.frmCrear_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsarioCrear;
        private System.Windows.Forms.TextBox txtPasswordCrear;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculion;
        public System.Windows.Forms.TextBox txtNombreCrear;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}