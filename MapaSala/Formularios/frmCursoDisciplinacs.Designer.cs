
namespace MapaSala.Formularios
{
    partial class frmCursoDisciplinacs
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
            this.Disciplinas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCursos = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CbxDisciplinas = new System.Windows.Forms.ComboBox();
            this.CbxPeriodos = new System.Windows.Forms.ComboBox();
            this.TxtPeriodo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(25, 36);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(57, 13);
            this.Disciplinas.TabIndex = 2;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // CbxCursos
            // 
            this.CbxCursos.FormattingEnabled = true;
            this.CbxCursos.Location = new System.Drawing.Point(365, 63);
            this.CbxCursos.Name = "CbxCursos";
            this.CbxCursos.Size = new System.Drawing.Size(121, 21);
            this.CbxCursos.TabIndex = 4;
            this.CbxCursos.SelectedIndexChanged += new System.EventHandler(this.cbxCursos_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(217, 63);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 255);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CbxDisciplinas
            // 
            this.CbxDisciplinas.FormattingEnabled = true;
            this.CbxDisciplinas.Location = new System.Drawing.Point(28, 63);
            this.CbxDisciplinas.Name = "CbxDisciplinas";
            this.CbxDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.CbxDisciplinas.TabIndex = 7;
            this.CbxDisciplinas.SelectedIndexChanged += new System.EventHandler(this.CbxDisciplinas_SelectedIndexChanged);
            // 
            // CbxPeriodos
            // 
            this.CbxPeriodos.FormattingEnabled = true;
            this.CbxPeriodos.Items.AddRange(new object[] {
            "1°Ano",
            "2°Ano",
            "3°Ano",
            "1°Modulo",
            "2°Modulo",
            "3°Modulo"});
            this.CbxPeriodos.Location = new System.Drawing.Point(568, 63);
            this.CbxPeriodos.Name = "CbxPeriodos";
            this.CbxPeriodos.Size = new System.Drawing.Size(121, 21);
            this.CbxPeriodos.TabIndex = 8;
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.AutoSize = true;
            this.TxtPeriodo.Location = new System.Drawing.Point(565, 39);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(43, 13);
            this.TxtPeriodo.TabIndex = 9;
            this.TxtPeriodo.Text = "Periodo";
            // 
            // frmCursoDisciplinacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPeriodo);
            this.Controls.Add(this.CbxPeriodos);
            this.Controls.Add(this.CbxDisciplinas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.CbxCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disciplinas);
            this.Name = "frmCursoDisciplinacs";
            this.Text = "frmCursoDisciplinacs";
            this.Load += new System.EventHandler(this.frmCursoDisciplinacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Disciplinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCursos;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CbxDisciplinas;
        private System.Windows.Forms.ComboBox CbxPeriodos;
        private System.Windows.Forms.Label TxtPeriodo;
    }
}