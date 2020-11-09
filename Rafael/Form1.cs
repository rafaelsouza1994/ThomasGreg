using Rafael;
using System;
using System.Data;
using System.Windows.Forms;

namespace Rafael
{
    public partial class Form1 : Form
    {
        public void DesativaCampos()
        {
            mtxtData.Enabled = false;
            txtCusto.Enabled = false;
            txtDistancia.Enabled = false;
            txtDor.Enabled = false;
            rbSim.Enabled = false;
            rbNao.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void AtivaCampos()
        {
            rbSim.Enabled = true;
            rbNao.Enabled = true;
            mtxtData.Enabled = true;
            txtCusto.Enabled = true;
            txtDistancia.Enabled = true;
            txtDor.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void LimpaCampos()
        {
            mtxtData.Clear();
            txtCusto.Clear();
            txtDistancia.Clear();
            txtDor.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
            DesativaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lvVoos.SelectedItems.Count > 0)
            {
                if (int.Parse(txtDor.Text) > 10)// | (int.Parse(txtDor.Text) < 0))
                {
                    MessageBox.Show("Valor digitado deve ser de 1 a 10!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDor.Clear();
                    txtDor.Focus();
                }
                else
                {
                    try
                    {
                        Voo voo = new Voo();
                        int updateId = Convert.ToInt32(labelId.Text);
                        voo.Id = updateId;
                        voo.Data = Convert.ToDateTime(mtxtData.Text);
                        voo.Custo = Convert.ToDouble(txtCusto.Text);
                        voo.Distancia = Convert.ToInt32(txtDistancia.Text);
                        voo.Captura = Convert.ToString(rbSim.Checked ? "S" : "N");
                        voo.Dor = Convert.ToInt32(txtDor.Text);
                        DalHelper.Update(voo);
                        ExibirDados();
                        LimpaCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);

                    }
                }
            }
            if (lvVoos.SelectedItems.Count == 0)
            {
                if (int.Parse(txtDor.Text) > 10)// | (int.Parse(txtDor.Text) < 0))
                {
                    MessageBox.Show("Valor digitado deve ser de 1 a 10!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDor.Clear();
                    txtDor.Focus();
                }
                else
                {
                    try
                    {
                        Voo voo = new Voo();
                        voo.Data = Convert.ToDateTime(mtxtData.Text);
                        voo.Custo = Convert.ToDouble(txtCusto.Text);
                        voo.Distancia = Convert.ToInt32(txtDistancia.Text);
                        voo.Captura = Convert.ToString(rbSim.Checked ? "S" : "N");
                        voo.Dor = Convert.ToInt32(txtDor.Text);


                        DalHelper.Add(voo);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    LimpaCampos();
                    DesativaCampos();
                    ExibirDados();
                }
            }
        }
        private void ExibirDados()
        {
            DataTable dt = new DataTable();
            dt = DalHelper.GetVoos();
            lvVoos.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["DATA_VOO"].ToString().Replace("00:00:00", "");
                lvi.SubItems.Add(dr["CAPTURA"].ToString());
                lvi.SubItems.Add(dr["NIVEL_DOR"].ToString());
                lvi.SubItems.Add(dr["ID_VOO"].ToString());
                lvi.SubItems.Add(dr["Distancia"].ToString());
                lvi.SubItems.Add(dr["Custo"].ToString());
                lvVoos.Items.Add(lvi);
            }
            lvVoos.View = View.Details;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvVoos.SelectedItems.Count > 0)
            {
                int deleteId = Convert.ToInt32(labelId.Text);
                DalHelper.Delete(deleteId);
                ExibirDados();
                LimpaCampos();
            }
        }

        private void lvVoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVoos.SelectedItems.Count > 0)
            {
                String data = lvVoos.SelectedItems[0].SubItems[0].Text;
                String captura = lvVoos.SelectedItems[0].SubItems[1].Text;
                String dor = lvVoos.SelectedItems[0].SubItems[2].Text;
                String id = lvVoos.SelectedItems[0].SubItems[3].Text;
                String distancia = lvVoos.SelectedItems[0].SubItems[4].Text;
                String custo = lvVoos.SelectedItems[0].SubItems[5].Text;

                mtxtData.Text = data;
                txtCusto.Text = custo;
                txtDistancia.Text = distancia;
                txtDor.Text = dor;
                labelId.Text = id;
                if (captura == "S")
                {
                    rbSim.Checked = true;
                    rbNao.Checked = false;
                }
                else
                {
                    rbNao.Checked = true;
                    rbSim.Checked = false;
                }
                AtivaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            ExibirDados();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            lvVoos.SelectedItems.Clear();
            AtivaCampos();
            LimpaCampos();
        }

        private void txtDor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}