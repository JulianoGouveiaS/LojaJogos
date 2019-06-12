using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Utils
{
   public class Utilitarios
    {
        public void preencherCombo(ComboBox cb, DataTable data, string valueMember, string displayMember) {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = data;
            cb.ValueMember = valueMember;
            cb.DisplayMember = displayMember;
            cb.Update();
        }

        public void lista(string tabela, DataGridView dataGrid, string VarOrdenacao )
        {
            ConnectionFactory connection = new ConnectionFactory();
            try
            {
                DataSet conexaoDataset = new DataSet();
                connection.Conectar();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM " + tabela + " ORDER BY " + VarOrdenacao, connection.getConnection());
                conexaoAdapter.Fill(conexaoDataset, tabela);
                dataGrid.DataSource = conexaoDataset;
                dataGrid.DataMember = tabela;
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                connection.Close();
            }
        }

        /* 

     //Deletar vendas quando deletar funcionario
delimiter #
create trigger tr_deleteFuncionario before delete on funcionarios
for each row
begin
delete from vendas where vendas.idFuncionarios = OLD.idFuncionarios;
end#
delimiter ; 

//Cadastrar backup quando editar vendas
delimiter #
create trigger tr_updateVendas after update on vendas
for each row
begin
insert into backup(descricao, valor, idClientes, idJogos, idFuncionarios) VALUES(new.descricao, new.valor, new.idClientes, new.idJogos, new.idFuncionarios);
end#
delimiter ; 

//Deleta vendas quando deletar jogos
delimiter #
create trigger tr_deleteJogos before delete on jogos
for each row
begin
delete from vendas where vendas.idJogos = OLD.idJogos;
end#
delimiter ; 

//Deleta vendas quando deletar clientes
delimiter #
create trigger tr_deleteCliente before delete on clientes
for each row
begin
delete from vendas where vendas.idClientes = OLD.idClientes;
end#
delimiter ; 

//Deleta jogos que conscequentemente deleta vendas quando deletar plataformas
delimiter #
create trigger tr_deletePlataforma before delete on plataformas
for each row
begin
delete from jogos where jogos.idPlataformas = OLD.idPlataformas;
end#
delimiter ; 



*/

    }
}
