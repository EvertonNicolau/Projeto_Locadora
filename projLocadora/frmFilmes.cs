using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLocadora
{
    public partial class frmFilmes : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtProdutoras = new DataTable();
        String connectionString = @"Server=darnassus\motorhead;Database=db_230065;User Id=230065;Password=R0@ne0804;";
        bool novo;
        DataTable dtFilmes = new DataTable();

        private void navegar()
        {
            carregaComboProdutoras();
            txtCodFilme.Text = dtFilmes.Rows[registroAtual][0].ToString();
            txtTituloFilme.Text = dtFilmes.Rows[registroAtual][1].ToString();
            txtAnoFilme.Text = dtFilmes.Rows[registroAtual][2].ToString();
            cmbGenero.Text = dtFilmes.Rows[registroAtual][4].ToString();
            //cmbProdutora.Text = dtFilmes.Rows[registroAtual][3].ToString();
            
        }
        private void carregaTudoProdutoras()
        {
            dtProdutoras = new DataTable();
            string sql = "SELECT * FROM tb_Produtora"; 
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtProdutoras.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            cmbProdutora.DataSource = dtProdutoras;
            cmbProdutora.DisplayMember = "NomeProd";
            cmbProdutora.ValueMember = "codProd";
        }
        private void carregaComboProdutoras()
        {
            dtProdutoras = new DataTable();
            string sql = "SELECT * FROM tb_Produtora WHERE codProd=" +
                dtFilmes.Rows[registroAtual][3].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtProdutoras.Load(reader);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            cmbProdutora.DataSource = dtProdutoras;
            cmbProdutora.DisplayMember = "NomeProd";
            cmbProdutora.ValueMember = "codProd";
        }
        public frmFilmes()
        {
            InitializeComponent();
        }

        private void txtSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                String sql = "INSERT INTO tb_Filmes(tiTuloFilme, anoFilme, codProd, generoFilme) VALUES ('" + txtTituloFilme.Text + "'," + txtAnoFilme.Text + ",'" + cmbProdutora.SelectedValue.ToString() + ",'" + cmbGenero.Text + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Filme cadastrado com sucesso");
                        this.frmFilmes_Load(this, e);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }

        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
                btnSalvar.Enabled = true;
                txtCodFilme.Enabled = false;
                txtTituloFilme.Enabled = false;
                txtAnoFilme.Enabled = false;
                cmbProdutora.Enabled = false;
                cmbGenero.Enabled = false;
                string sql = "SELECT * FROM tb_Filme";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                con.Open();
                try
                {
                    using (reader = cmd.ExecuteReader())
                    {
                        dtFilmes.Load(reader);
                        totalRegistros = dtFilmes.Rows.Count;
                        registroAtual = 0;
                        navegar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if(registroAtual < totalRegistros - 1)
            {
                registroAtual++;
                navegar();
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual--;
                navegar();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual = 0;
                navegar();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual = totalRegistros - 1;
                navegar();
            }
        }

        private void txtExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tb_Filme WHERE codFilmes=" + txtCodFilme.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Filme excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            cmbProdutora.DataSource = dtProdutoras;
            cmbProdutora.DisplayMember = "NomeProd";
            cmbProdutora.ValueMember = "codProd";

            btnSalvar.Enabled = false;
            txtTituloFilme.Enabled = false;
            txtCodFilme.Enabled = false;
            txtAnoFilme.Enabled = false;
            cmbProdutora.Enabled = false;
            cmbGenero.Enabled = true;
            txtExcluir.Enabled = true;
            txtModificar.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            dtFilmes = new DataTable();
            this.frmFilmes_Load(this, e);
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            novo: true;
            btnSalvar.Enabled = false;
            txtTituloFilme.Enabled = false;
            txtCodFilme.Enabled = false;
            txtAnoFilme.Enabled = false;
            cmbProdutora.Enabled = false;
            cmbGenero.Enabled = true;
            txtExcluir.Enabled = true;
            txtModificar.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            carregaTudoProdutoras();
         
        }

        private void txtNovo_Click(object sender, EventArgs e)
        {
            novo: true;
            btnSalvar.Enabled = false;
            txtTituloFilme.Enabled = false;
            txtTituloFilme.Clear();
            txtCodFilme.Enabled = false;
            txtAnoFilme.Enabled = false;
            txtAnoFilme.Clear();
            cmbProdutora.Enabled = false;
            cmbGenero.Enabled = true;
            cmbGenero.SelectedIndex = -1;
            txtExcluir.Enabled = true;
            txtModificar.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            carregaTudoProdutoras();
            cmbProdutora.SelectedIndex = 0;
            txtCodFilme.Clear();
        }
    }
}

