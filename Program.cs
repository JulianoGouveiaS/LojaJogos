using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }


        //Crud exemplos
        /*
         private ConnectionFactory connection = new ConnectionFactory();
          public void Salvar(AdministradorDomain administrador)
          {
              try
              {
                  connection.Conectar();
                  // connectbd();
                  MySqlCommand cmd = new MySqlCommand();
                  cmd.Connection = connection.getConnection();
                  cmd.CommandText = "INSERT INTO administrador(nome) VALUES(?nome)";
                  cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = administrador.getNome();
                  cmd.ExecuteNonQuery();
                  MessageBox.Show("Conexao efetuada com sucesso");

              } catch(MySqlException ex)
              {
                  MessageBox.Show("Nao deu certo a conexao!!");
              }
              finally
              {
                  connection.Close();
              }
          }



          public void Excluir(int id)
          {
              connection.Conectar();
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection.getConnection();
              //cmd.CommandText = "DELETE from administrador WHERE id_administrados" +
              //    " = ?id_administrados";
              cmd.CommandText = "DELETE from administrador WHERE id_administrados" +
                 " = ?id_administrados";
              cmd.Parameters.Add("?id_administrados", MySqlDbType.Int32).Value = id;
              //cmd.Parameters.Add("?Administrador_id_administrados", MySqlDbType.Int32).Value = id;
              MySqlDataReader leitor = cmd.ExecuteReader();
              leitor.Read();


              
             // cmd.CommandText = "DELETE from administrador, funcionario_has_administrador WHERE id_administrados" +
               //  " = ?id_administrados and administrador_id_administrados = ?Administrador_id_administrados";
               


    }

    public MySqlDataReader Select()
    {
        AdministradorDomain admDomain = new AdministradorDomain();
        connection.Conectar();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = connection.getConnection();
        cmd.CommandText = "SELECT * from administrador";

        MySqlDataReader leitor = cmd.ExecuteReader();




        //admDomain.setId(int.Parse(leitorMySQL["id_administrados"].ToString()));
        //admDomain.setNome(leitorMySQL["nome"].ToString());

        return leitor;

    }
    public void PreencherComboBoxAdm(ComboBox comboBoxAdm)
    {
        DataTable tabelaAdministrador = new DataTable();
        // AdministradorDomain admDomain = new AdministradorDomain();
        AdministradorDAO admDAO = new AdministradorDAO();
        MySqlDataReader leitor = admDAO.Select();

        tabelaAdministrador.Load(leitor);

        comboBoxAdm.ValueMember = "id_administrados";
        comboBoxAdm.DisplayMember = "nome";
        comboBoxAdm.DataSource = tabelaAdministrador;

    }

    public void Editar(AdministradorDomain admDomain)
    {
        connection.Conectar();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = connection.getConnection();
        cmd.CommandText = "UPDATE administrador SET nome = ?nome WHERE id_administrados = ?id_administrados";
        cmd.Parameters.Add("?nome", MySqlDbType.String).Value = admDomain.getNome();
        cmd.Parameters.Add("?id_administrados", MySqlDbType.Int32).Value = admDomain.getId();
        cmd.ExecuteNonQuery();
        // MySqlDataReader leitor = cmd.ExecuteReader();
        // leitor.Read();

    }
       */


    }


}
