
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ObiGarm.ClassDatabase
{
    class SqlConfiguration
    {
        public static String datasource { get; set; }        
        public static String username { get; set; }
        public static String password { get; set; }
        public static String database { get; set; }
        public static String port { get; set; }

        public static MySqlConnection connection;

        public MySqlDataAdapter dataAdapter;
        public DataTable dataTable;
        private MySqlCommand cmd;

        public static bool getConnection()
        {
            string sql = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database + ";";

            try
            {
                connection = new MySqlConnection(sql);
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Хатоги хангоми пайвастшави ба база!\n\n\n" + e.ToString(), "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Хатоги хангоми пушидани база!\n" + e.ToString(), "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public DataTable sqlSelectQuery(string sql)
        {
            openConnection();

            try
            {
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                return dataTable;

            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }

        public void displayList(string sql, DataGridView dataGridView)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;

                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;

            }

            catch (Exception ex)
            {

            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }


        public void displayListExpress(string sql, DevExpress.XtraGrid.GridControl dataGridView)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;

                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;

            }

            catch (Exception ex)
            {

            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }

        public int sqlQuery(string sql)
        {

            try
            {
                openConnection();

                cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                return 1;

            }

            catch (Exception)
            {
                return 500;
            }

            finally
            {
                closeConnection();
                cmd = null;
            }
        }

        public void LoadComboDE(string sql, string name_collum, string valus_colum, DevExpress.XtraEditors.LookUpEdit combo)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count != null || dataTable.Rows.Count != null)
                {

                    combo.Properties.DataSource= dataTable;

                    combo.Properties.DisplayMember = name_collum;
                    combo.Properties.ValueMember = valus_colum;

                }


            }

            catch (Exception ex)
            {

            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }

        public void LoadCombo(string sql, string name_collum, string valus_colum, Guna.UI2.WinForms.Guna2ComboBox combo)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count!=null || dataTable.Rows.Count != null)
                {
                    combo.DataSource = dataTable;

                    combo.DisplayMember = name_collum;
                    combo.ValueMember = valus_colum;
                }

               
            }

            catch (Exception ex)
            {
               
            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }
        
        public void LoadList(string sql, string name_collum, string valus_colum, DevExpress.XtraEditors.ListBoxControl list)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand();
                dataAdapter = new MySqlDataAdapter();
                dataTable = new DataTable();


                cmd.Connection = connection;
                cmd.CommandText = sql;
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count != null || dataTable.Rows.Count != null)
                {
                    list.DataSource = dataTable;

                    list.DisplayMember = name_collum;
                    list.ValueMember = valus_colum;
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                closeConnection();
                cmd = null;
                dataAdapter = null;
                dataTable = null;
            }
        }
    }
    public class PersonInfo
    {
        private string _id;
        private string _name;

        public PersonInfo(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return _id + " " + _name;
        }
    }
}
