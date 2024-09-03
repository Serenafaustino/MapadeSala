using MapaSala.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCursoDisciplinacs : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        public frmCursoDisciplinacs()
        {
            InitializeComponent();

            CbxDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            CbxDisciplinas.DisplayMember = "Nome";
            CbxDisciplinas.ValueMember = "Id";

            CbxCursos.DataSource = cursoDAO.PreencherComboBox();
            CbxCursos.DisplayMember = "Nome";
            CbxCursos.ValueMember = "Id";

           // lsDisciplinas.Items.AddRange(disciplinaDAO.Listbox());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCursoDisciplinacs_Load(object sender, EventArgs e)
        {

        }

        private void CbxDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
