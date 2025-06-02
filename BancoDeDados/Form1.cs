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

namespace BancoDeDados
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leona\source\repos\BancoDeDados\BancoDeDados\banco.mdf;Integrated Security=True");



        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão\n" + ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "insert into alunos (Id,nome,curso) values (" + txtId.Text + ", '" + txtNome.Text + "', '" + txtCurso.Text + "')";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    MessageBox.Show("Cadastro Efetuado");
                }
                else
                {
                    MessageBox.Show("Cadastro não efetuado");
                }
                txtCurso.Text = "";
                txtId.Text = "";
                txtNome.Text = "";
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando Sql\n" + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "select * from alunos where Id = " + txtId.Text;
                cmd = new SqlCommand(sql, conexao);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    txtNome.Text = dr["nome"].ToString();
                    txtCurso.Text = dr["curso"].ToString();
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado !");
                }
                dr.Close();
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comado SQL" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "delete from alunos where Id = " + txtId.Text;
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    MessageBox.Show("Deletado com sucesso !");
                }
                else
                {
                    MessageBox.Show("Cadastro não foi deletado");
                }
                txtCurso.Text = "";
                txtId.Text = "";
                txtNome.Text = "";
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando SQL\n" + ex.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            AlunosCadastrados f2 = new AlunosCadastrados();
            f2.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sql;
            int retorno;
            try
            {
                sql = "UPDATE alunos SET nome = '" + txtNome.Text + "', curso = '"+ txtCurso.Text + "' WHERE Id = "+ txtId.Text;
                cmd = new SqlCommand(sql, conexao);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    MessageBox.Show("Alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Cadastro não foi alterado");
                }

                txtCurso.Text = "";
                txtId.Text = "";
                txtNome.Text = "";
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro no comando SQL\n" + ex.Message);
            }
        }
    }
}
