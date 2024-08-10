namespace SistemaAcademico
{
    partial class Formulario3
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
            ListViewGroup listViewGroup1 = new ListViewGroup("", HorizontalAlignment.Left);
            btnSalir = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            button1 = new Button();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            txtMatricula = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboCurso = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(392, 27);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 30);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(39, 27);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 30);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(274, 27);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(122, 30);
            btnGrabar.TabIndex = 13;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(154, 27);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(502, 76);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 17;
            dtpFecha.TabStop = false;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(126, 139);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(186, 27);
            txtMatricula.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 142);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 20;
            label2.Text = "Matricula:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(407, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(186, 27);
            txtApellido.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 27);
            txtNombre.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 175);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 25;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 175);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 24;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 216);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 28;
            label5.Text = "Curso/Nivel:";
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Items.AddRange(new object[] { "Ing. Software", "Ing. Sistema", "Medicina", "Robotica", "Mecatronica" });
            cboCurso.Location = new Point(139, 213);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(151, 28);
            cboCurso.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 327);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 263);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 31;
            label7.Text = "Materias:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewGroup1.Name = "Codigo";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listView1.Location = new Point(53, 286);
            listView1.Name = "listView1";
            listView1.Size = new Size(452, 207);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Materias";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prerequisitos";
            columnHeader3.Width = 150;
            // 
            // Formulario3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cboCurso);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMatricula);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnGrabar);
            Name = "Formulario3";
            Text = "Pantalla de Admision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnNuevo;
        private Button btnGrabar;
        private Button button1;
        private Label label1;
        private DateTimePicker dtpFecha;
        private TextBox txtMatricula;
        private Label label2;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboCurso;
        private Label label6;
        private Label label7;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}