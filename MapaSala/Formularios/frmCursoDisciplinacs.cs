using MapaSala.DAO;
using Model.Entitidades;
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
        CursoDisplinaDAO dao = new CursoDisplinaDAO();
        private void AtualizarGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }
        public frmCursoDisciplinacs()
        {
            InitializeComponent();

            CbxDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            CbxDisciplinas.DisplayMember = "Nome";
            CbxDisciplinas.ValueMember = "Id";

            CbxCursos.DataSource = cursoDAO.PreencherComboBox();
            CbxCursos.DisplayMember = "Nome";
            CbxCursos.ValueMember = "Id";

            AtualizarGrid(dao.ObterCursoDisciplina());

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
            CursoDisplinaDAO cursoDisciplinaDao = new CursoDisplinaDAO();
            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();


            entidade.CursoId = Convert.ToInt32(CbxCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(CbxDisciplinas.SelectedValue);
            entidade.Periodo = CbxPeriodos.SelectedItem.ToString();
            cursoDisciplinaDao.Inserir(entidade);

            AtualizarGrid(dao.ObterCursoDisciplina());
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
