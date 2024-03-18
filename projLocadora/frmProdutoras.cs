using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projLocadora
{
    public partial class frmProdutoras : Form
    {
        String connectionString = @"Server=darnassus\motorhead;Database=db_230065;User Id=230065;Password=R0@ne0804;";
        bool novo;

        public frmProdutoras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProdutoras_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtCodProd.Enabled = false;
            txtEmailProd.Enabled = false;
            txtProd.Enabled = false;
            txtTelProd.Enabled = false;
            string sql = "SELECT * FROM tb_Produtora";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodProd.Text = reader[0].ToString();
                    txtProd.Text = reader[1].ToString();
                    txtTelProd.Text = reader[2].ToString();
                    txtEmailProd.Text = reader[3].ToString();
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
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            txtProd.Enabled = true;
            txtEmailProd.Enabled = true;
            txtTelProd.Enabled = true;
            btnExcluir.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnAlterar.Enabled = false;
            novo = true;
            txtProd.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (novo)
            {
                string sql = "INSERT INTO tb_Produtora (nomeProd, telProd, emailProd) VALUES('" + txtProd.Text + "', '" + txtTelProd.Text + "', '" + txtEmailProd.Text + "')";
                //MessageBox.Show ()(sql);
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastrada com sucesso!");
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
                string sql = "UPDATE tb_Produtora SET nomeProd='" + txtProd.Text + "', emailProd='" + txtEmailProd.Text + "', telProd='" + txtTelProd.Text + "' WHERE codProd=" + txtCodProd.Text;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i>0)
                    {
                        MessageBox.Show("Produtora alterada com sucesso!");
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
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tb_Produtora WHERE codProd=" + txtCodProd.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Produtora apagada com sucesso!");
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
            btnSalvar.Enabled = true;
            txtCodProd.Enabled = false;
            txtEmailProd.Enabled = false;
            txtProd.Enabled = false;
            txtTelProd.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
     

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            novo = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtProd.Enabled = true;
            txtEmailProd.Enabled = true;
            txtTelProd.Enabled = true;

        }
    }
}
