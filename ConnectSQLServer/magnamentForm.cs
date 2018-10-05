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
using System.Threading;


namespace ConnectSQLServer
{
    public partial class magnamentForm : Form
    {
        String currentDB;
        String currentTable;
        DataTable columns;
        Label[] labels;
        TextBox[] input;
        CheckBox[] check;
        SqlServer connection;

        public magnamentForm(SqlServer c)
        {
            InitializeComponent();
            this.connection = c;
            createUI();
        }

        private void magnamentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.connection.Close();
            Application.Exit();
        }

        private void createUI()
        {
            DataTable databases = connection.connection.GetSchema("Databases");
            foreach (DataRow database in databases.Rows)
            {
                String databaseName = database.Field<String>("database_name");
                /*short dbID = database.Field<short>("dbid");
                DateTime creationDate = database.Field<DateTime>("create_date");*/
                dbList.Items.Add(databaseName);
                
            }
            dbList.SetSelected(0, true);
        }

        private void dbList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                connection.checkConnection();
                ListBox l = (ListBox)sender;
                currentDB = l.GetItemText(l.SelectedItem);
                connection.connection.ChangeDatabase(currentDB);
                DataTable tables = connection.connection.GetSchema("tables");
                tablesList.Items.Clear();
                foreach (DataRow table in tables.Rows)
                {
                    String tableName = table.Field<String>("table_name");
                    
                    tablesList.Items.Add(tableName);
                }
                tablesList.SetSelected(0, true);
            }catch
            {                
            }
        }

        private void tablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int top = 0;
                uint count = 0;
                Button insert;
                connection.checkConnection();
                ListBox l = (ListBox)sender;
                currentTable = l.GetItemText(l.SelectedItem);
                columns = connection.connection.GetSchema("Columns", new[] { currentDB, null, currentTable});
                if (columns.Rows.Count > 0)
                {
                    labels = new Label[columns.Rows.Count];
                    input = new TextBox[columns.Rows.Count];
                    check = new CheckBox[columns.Rows.Count];
                    this.insert.Controls.Clear();
                    foreach (DataRow rows in columns.Rows)
                    {
                        String row = rows.Field<String>("column_name");
                        labels[count] = new Label();
                        labels[count].Text = row;
                        labels[count].Location = new Point(10, top);
                        input[count] = new TextBox();
                        input[count].Location = new Point(10, top + 25);
                        input[count].Width = 100;
                        check[count] = new CheckBox();
                        check[count].Text = "use";
                        check[count].Checked = true;
                        check[count].Location = new Point(120, top + 20);
                        this.insert.Controls.Add(labels[count]);
                        this.insert.Controls.Add(input[count]);
                        this.insert.Controls.Add(check[count]);
                        count++;
                        top += 45;
                        //MessageBox.Show(row);
                    }
                    insert = new Button();
                    insert.Text = "Insert";
                    insert.Width = input[0].Width;
                    insert.Location = new Point(10, top + 10);
                    this.insert.Controls.Add(insert);
                    insert.Click += new EventHandler(this.insert_click);
                }

            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void insert_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader readQuery;
                String[] values = new String[columns.Rows.Count];
                bool[] use = new bool[columns.Rows.Count];
                for (uint i = 0; i < columns.Rows.Count; i++)
                {
                    values[i] = input[i].Text;
                    use[i] = check[i].Checked;
                }
                cmd.CommandText = connection.insertQuery(currentDB, currentTable, columns, values, use);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;

                readQuery = cmd.ExecuteReader();
                MSG.Text = "";
                StringBuilder sb = new StringBuilder();
                if (readQuery.HasRows)
                {
                    if (sb.Length > 0) sb.Append("___");
                    while (readQuery.Read())
                    {
                        for (int i = 0; i < readQuery.FieldCount; i++)
                            if (readQuery.GetValue(i) != DBNull.Value)
                                sb.AppendFormat("{0}-\n", Convert.ToString(readQuery.GetValue(i)));
                    }
                    MSG.Text = sb.ToString();
                    
                }else
                {
                    MSG.Text = "Success Transact-Sql Query\n1 row affected";
                }
                readQuery.Close();
                

            }
            catch(Exception error)
            {
                MSG.Text = error.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader readQuery;
                uint count = 0;
                cmd.CommandText = querytxt.Text;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;

                readQuery = cmd.ExecuteReader();
                MSG.Text = "";
                StringBuilder sb = new StringBuilder();
                if (readQuery.HasRows)
                {
                    if (sb.Length > 0) sb.Append("___");
                    while (readQuery.Read())
                    {
                        count++;
                        for (int i = 0; i < readQuery.FieldCount; i++)
                        {
                            if (readQuery.GetValue(i) != DBNull.Value)
                                sb.AppendFormat("{0}   ", Convert.ToString(readQuery.GetValue(i)));
                            
                        }
                       
                        sb.AppendFormat("{0}", "\n");
                    }
                    sb.AppendFormat("Success Transact-Sql Query\n{0} rows affected", count);
                    MSG.Text = sb.ToString();
                }
                else
                {
                    MSG.Text = "Success Transact-Sql Query\n 0 rows affected";
                }
                readQuery.Close();
            } catch(Exception error)
            {
                MSG.Text = error.Message;
            }
        }
    }
}
