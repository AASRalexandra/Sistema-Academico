namespace SistemaAcademico
{
    partial class Formulario4
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
            button1 = new Button();
            btnSalir = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtMateria = new TextBox();
            label3 = new Label();
            txtPrerequisito = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(184, 12);
            button1.Name = "button1";
            button1.Size = new Size(124, 37);
            button1.TabIndex = 19;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(422, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 37);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(69, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 37);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(304, 12);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(122, 37);
            btnGrabar.TabIndex = 17;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 20;
            label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(122, 91);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(234, 27);
            txtCodigo.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 155);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 22;
            label2.Text = "Materia:";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(108, 152);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(125, 27);
            txtMateria.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 242);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 32;
            label3.Text = "Prerequisito:";
            // 
            // txtPrerequisito
            // 
            txtPrerequisito.Location = new Point(239, 242);
            txtPrerequisito.Name = "txtPrerequisito";
            txtPrerequisito.Size = new Size(243, 27);
            txtPrerequisito.TabIndex = 33;
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrerequisito);
            Controls.Add(label3);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnGrabar);
            Name = "Formulario4";
            Text = "Registro Curricular ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnGrabar;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtMateria;
        private Label label3;
        private TextBox txtPrerequisito;
    }
}