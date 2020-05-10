using System;
using System.Collections;
using System.Collections.Generic;

using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_productenDB
{
    public partial class Form1 : Form
    {
        //MySQL Connection variable
        private string mySqlConnStr = null;
        private MySqlConnection mySqlConn;
        private MySqlCommand mySqlComm;

        public Form1()
        {
            InitializeComponent();
            ConnectionStringSettingsCollection connectionStringSettings = GetConnectionStrings();
            UpdateConnectionsComboBox(DropDownConnections, connectionStringSettings);
            mySqlConnStr = DropDownConnections.SelectedValue.ToString();
        }

        private static Dictionary<string, string> UpdateConnectionsComboBox(ComboBox cb, IEnumerable cssc)
        {
            Dictionary<string, string> csd = new Dictionary<string, string>();

            if (cssc != null)
            {
                foreach (ConnectionStringSettings cs in cssc)
                {
                    csd.Add(cs.Name, cs.ConnectionString);
                }

                cb.DataSource = new BindingSource(csd, null);
                cb.DisplayMember = "Key";
                cb.ValueMember = "Value";
            }
            else
            {
                cb.Enabled = false;
            }
            return csd;
        }

        private static ConnectionStringSettingsCollection GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings = new ConnectionStringSettingsCollection();

            try
            {
                settings = ConfigurationManager.ConnectionStrings;
            }
            catch (ConfigurationErrorsException err)
            {
                MessageBox.Show(err.Message, @"Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return settings;
        }

        private static MySqlConnection OpenMySQLverbinding(string connectionString)
        {
            MySqlConnection myConnection = null;


            try
            {
                myConnection = new MySqlConnection(connectionString);

                try
                {
                    myConnection.Open();
                }
                catch (MySqlException)
                {
                    MessageBox.Show(@"Error connecting to database", @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    myConnection.Dispose();
                }
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message, @"SQL-Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection?.Dispose();
            }

            return myConnection;
        }

        private void DropDownConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlConnStr = DropDownConnections.SelectedValue.ToString();
            string[] strList = mySqlConnStr.Split(';');
            string str = strList.Where(s => !s.Contains("password")).Aggregate(string.Empty, (current, s) => current + (s + " , "));
        }

        private void UpdateButtonsOnCloseConnection()
        {
            OpenMySQLButton.Enabled = true;
            btnCloseMySql.Enabled = false;
            lblSqlVerbindingsStatus.Visible = false;
        }

        private void UpdateButtonsOnOpenConnection()
        {
            OpenMySQLButton.Enabled = false;
            btnCloseMySql.Enabled = true;
            lblSqlVerbindingsStatus.Visible = true;
        }

        private void OpenMySQLButton_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConn = OpenMySQLverbinding(mySqlConnStr);

                try
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        tmrVerbindingsTijd.Enabled = true;
                        UpdateButtonsOnOpenConnection();
                        MessageBox.Show(@"Connecting to the database was successful.");
                    }
                    else
                    {
                        MessageBox.Show(@"Connecting to the database failed.");
                    }
                }
                catch (NullReferenceException err)
                {
                    MessageBox.Show(err.Message, @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show(@"Connecting to the database failed.");
            }
        }

        private void btnCloseMySql_Click(object sender, EventArgs e)
        {
            if (CloseMySQLverbinding(mySqlConn))
            {
                tmrVerbindingsTijd.Enabled = false;
                UpdateButtonsOnCloseConnection();
                MessageBox.Show(@"Disconnected successfully");
            }
            else
            {
                MessageBox.Show(@"Fail to disconnect");
            }
        }

        private static bool CloseMySQLverbinding(IDbConnection myConnection)
        {
            bool succeed = false;

            if (myConnection.State == ConnectionState.Open)
            {
                try
                {
                    myConnection.Close();
                    succeed = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show(@"Error closing connection to database", @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"No open SQL-connection", @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return succeed;
        }

        private void btnConnectAndClose_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {

                        mySqlComm = new MySqlCommand
                        {
                            Connection = mySqlConn,
                            CommandText = "select * from orders;",
                            CommandType = CommandType.Text
                        };


                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            rtbReadOut.Text = "";
                            while (mySqlDr.Read())
                            {
                                for (int i = 0; i < mySqlDr.FieldCount; i++)
                                {
                                    rtbReadOut.AppendText(mySqlDr[i].ToString() + "\t");
                                }
                                rtbReadOut.AppendText("\n");

                            }
                            mySqlDr.Close();

                        }


                    }
                    else
                    {
                        MessageBox.Show(@"No connection to database");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {

                        mySqlComm = new MySqlCommand {Connection = mySqlConn};
                        mySqlComm.Parameters.AddWithValue("@orderID", OrderControleTextBox.Text);
                        mySqlComm.CommandText = mySqlComm.CommandText =
                            "select orderID, bestelDatum, klanten.klantID, klanten.klantNaam, producten.productID, producten.productNaam, bestelhoeveelheid, afgehandelt from orders inner join klanten on(klanten.klantID = orders.klantID) inner join producten on(producten.productID = orders.productID) where orderID = @orderID;";
                        mySqlComm.CommandType = CommandType.Text;


                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            rtbReadOut.Text = "";
                            while (mySqlDr.Read())
                            {

                                for (int i = 0; i < mySqlDr.FieldCount; i++)
                                {

                                    rtbReadOut.AppendText(mySqlDr[i].ToString() + "\t");
                                }

                                rtbReadOut.AppendText("\n");

                            }

                            mySqlDr.Close();

                        }

                    }
                    else
                    {
                        MessageBox.Show(@"No connection to database");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {

                        mySqlComm = new MySqlCommand {Connection = mySqlConn};
                        mySqlComm.Parameters.AddWithValue("@productNaam", rtbProductnaam.Text);
                        mySqlComm.Parameters.AddWithValue("@productStock", tbProductStock.Text);
                        mySqlComm.CommandText =
                            ("insert into producten(productNaam, productStock, beschikbaarheid) values (@productNaam,@productStock,1);");
                        mySqlComm.CommandType = CommandType.Text;
                        mySqlComm.ExecuteNonQuery();

                        rtbProductnaam.Text = "";
                        tbProductStock.Text = "";
                        MessageBox.Show(@"successfully added");
                    }
                    else
                    {
                        MessageBox.Show(@"No connection to database");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }

        private void LeesTableButton_Click(object sender, EventArgs e)
        {
            ReadTableProducts();
        }

        private void ReadTableProducts()
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        dataGridView1.Rows.Clear();
                        mySqlComm = new MySqlCommand
                        {
                            Connection = mySqlConn,
                            CommandText = "select * from producten;",
                            CommandType = CommandType.Text
                        };


                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            rtbReadOut.Text = "";
                            while (mySqlDr.Read())
                            {
                                List<string> temp = new List<string>();
                                for (int i = 0; i < mySqlDr.FieldCount; i++)
                                {
                                    temp.Add(mySqlDr[i].ToString());
                                }

                                dataGridView1.Rows.Add(temp.ToArray());

                            }
                            mySqlDr.Close();

                            dataGridView1.AutoResizeRows();
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoSize = true;
                        }


                    }
                    else
                    {
                        MessageBox.Show(@"No connection to database");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, @"MySQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string ID = dataGridView1[0, row].Value.ToString();
            if (MessageBox.Show(@"Do you want to remove " + ID + @"?", @"warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                    {


                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            mySqlComm = new MySqlCommand
                            {
                                Connection = mySqlConn,
                                CommandText = ("delete from producten where productID = " + ID + ";"),
                                CommandType = CommandType.Text
                            };

                            mySqlComm.ExecuteNonQuery();
                            MessageBox.Show(@"product removed", "", MessageBoxButtons.OK);

                        }


                        ReadTableProducts();
                    }
                }
                catch (MySqlException error)
                {
                    MessageBox.Show(error.Message, @"error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
