namespace SistemaAcademico
{
    partial class Formulario2
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
            btnSalir = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            lblCurso = new Label();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            listBox1 = new ListBox();
            cboCurso = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(382, 28);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(172, 31);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(51, 28);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(172, 31);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(216, 28);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(170, 31);
            btnGrabar.TabIndex = 10;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(83, 107);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(0, 20);
            lblCurso.TabIndex = 12;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.BorderStyle = BorderStyle.FixedSingle;
            ContentPanel.Size = new Size(270, 209);
            ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "" });
            listBox1.Location = new Point(153, 181);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(458, 264);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Items.AddRange(new object[] { "Ing. Software", "Ing. Sistema", "Medicina", "Robotica", "Mecatronica" });
            cboCurso.Location = new Point(213, 104);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(373, 28);
            cboCurso.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 107);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 30;
            label5.Text = "Curso/Nivel:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(153, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 38);
            textBox1.TabIndex = 35;
            textBox1.Text = "Descripcion                                 Codigo";
            // 
            // Formulario2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 482);
            Controls.Add(textBox1);
            Controls.Add(cboCurso);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(lblCurso);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnGrabar);
            Name = "Formulario2";
            Text = "Registro de Curso/Nivel";
            Load += Formulario2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnNuevo;
        private Button btnGrabar;
        private Label lblCurso;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ListBox listBox1;
        private ComboBox cboCurso;
        private Label label5;
        private TextBox textBox1;
    }
}