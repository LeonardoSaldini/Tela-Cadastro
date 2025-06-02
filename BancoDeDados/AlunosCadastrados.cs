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
using System.Net.Http.Headers;

namespace BancoDeDados
{
    public partial class AlunosCadastrados : Form
    {

        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leona\source\repos\BancoDeDados\BancoDeDados\banco.mdf;Integrated Security=True");



        SqlCommand cmd;
        SqlDataReader dr;
        public AlunosCadastrados()
        {
            InitializeComponent();
        }

        private void AlunosCadastrados_Load(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conexao.Open();
                sql = "select id from alunos";
                cmd = new SqlCommand(sql, conexao);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbxDados.Items.Add(dr["ID"].ToString());
                }
                cmd.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO\n" + ex.Message);
            }
        }

        private void lbxDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from alunos where id = " + lbxDados.SelectedItem;
            try
            {
                cmd = new SqlCommand(sql, conexao);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    txtId.Text = dr["ID"].ToString();
                    txtNome.Text = dr["Nome"].ToString();
                    txtCurso.Text = dr["Curso"].ToString();
                }
                cmd.Dispose();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO\n" + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
