using EscolaClient.EscolaService;
using EscolaClient.EscolaServiceAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            using (NotasServiceClient client = new NotasServiceClient("WSHttpBinding_INotasService"))
            {
                try
                {
                    var nota = new EscolaService.Nota()
                    {
                        AlunoId = (int)cboAluno.SelectedValue,
                        DisciplinaId = (int)cboDisciplina.SelectedValue,
                        Pontos = Convert.ToDecimal(txtNota.Text)
                    };

                    await client.EnviarNotasAsync(nota);

                    ts.Complete();
                }
                catch (FaultException<ErroProcessamento> ex)
                {
                    MessageBox.Show("FaultException<ErroProcessamento> throw by service.\r\n Exception type: FaultException<ErroProcessamento>" +
                        "\r\nReason:" + ex.Message +
                        "\r\nCodigo:" + ex.Detail.Codigo +
                        "\r\nMessagem:" + ex.Detail.Messagem +
                        "\r\nData:" + ex.Detail.Data);
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("FaultException throw by service.\r\n Exception type: FaultException" +
                        "\r\nMessage:" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception throw by service.\r\n Exception type: " + ex.GetType().Name +
         "\r\nMessage:" + ex.Message);

                    ts.Dispose();
                }
                finally
                {
                    client.Close();
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cboAluno.DropDownStyle = cboDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;

            cboAluno.ValueMember = "Id";
            cboAluno.DisplayMember = "Nome";

            cboDisciplina.ValueMember = "Id";
            cboDisciplina.DisplayMember = "Nome";

            using (NotasServiceClient proxy = new NotasServiceClient("WSHttpBinding_INotasService"))
            {
                cboAluno.DataSource = await proxy.GetAlunosAsync();
                cboDisciplina.DataSource = await proxy.GetDisciplinasAsync();

                proxy.Close();
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            using (NotasServiceAdminClient client = new NotasServiceAdminClient("WSHttpBinding_INotasServiceAdmin"))
            {
                try
                {
                    var nota = new EscolaServiceAdmin.Nota()
                    {
                        AlunoId = (int)cboAluno.SelectedValue,
                        DisciplinaId = (int)cboDisciplina.SelectedValue,
                        Pontos = Convert.ToDecimal(txtNota.Text)
                    };

                    await client.AtualizarNotaAsync(nota);

                    ts.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception throw by service.\r\n Exception type: " + ex.GetType().Name +
                        "\r\nMessage:" + ex.Message);

                    ts.Dispose();
                }
                finally
                {
                    client.Close();
                }
            }
        }
    }
}
