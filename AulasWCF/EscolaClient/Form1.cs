using EscolaClient.EscolaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            using (NotasServiceClient client = 
                new NotasServiceClient("WSHttpBinding_INotasService"))
            {
                var nota = new Nota()
                {
                    AlunoId = (int)cboAluno.SelectedValue,
                    DisciplinaId = (int)cboDisciplina.SelectedValue,
                    Pontos = Convert.ToDecimal(txtNota.Text)
                };

                await client.EnviarNotasAsync(nota);

                client.Close();
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cboAluno.DropDownStyle = cboDisciplina.DropDownStyle = 
                ComboBoxStyle.DropDownList;

            cboAluno.ValueMember = "Id";
            cboAluno.DisplayMember = "Nome";

            cboDisciplina.ValueMember = "Id";
            cboDisciplina.DisplayMember = "Nome";

            using (NotasServiceClient proxy = 
                new NotasServiceClient("WSHttpBinding_INotasService"))
            {
                cboAluno.DataSource = await proxy.GetAlunosAsync();
                cboDisciplina.DataSource = await proxy.GetDisciplinasAsync();

                proxy.Close();
            }
        }
    }
}
