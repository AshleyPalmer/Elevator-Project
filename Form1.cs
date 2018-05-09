using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AshleysElevator
{
    public partial class Form1 : Form
    {
        //status of the lift, shared by multiple event handlers
        private int lift_status;

        public Form1()
        {
            InitializeComponent();
            //Initialise the position of the lift on start
            lift_status = 0;
            //This code tells us where thr list is on all three labels
            label1.Text = lift_status.ToString();
            label2.Text = lift_status.ToString();
            label3.Text = lift_status.ToString();

            //Establish the connection of the adaptor
            string connectionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbadaptor;
            DataSet ds = new DataSet();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source=Elevator_Log_Ashley.accdb;";
            connection = new OleDbConnection(connectionString);
            try
            {
                //Opening the connection and selecting everything from Elevator (log table)
                connection.Open();
                oledbadaptor = new OleDbDataAdapter("select * from Elevator", connection);
                oledbadaptor.Fill(ds);
                oledbadaptor.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //Make change is ListView Accordingly
                    ListViewItem list = new ListViewItem(row["ElevatorID"].ToString());
                    list.SubItems.Add(row["Status"].ToString());
                    list.SubItems.Add(row["StatusDate"].ToString());
                    list.SubItems.Add(row["StatusTime"].ToString());
                    list.SubItems.Add(row["Statuslift"].ToString());
                    listView1.Items.Add(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region Code for Up and Down buttons

        //request Button for the lift to go to the first floor

        private void button4_Click(object sender, EventArgs e)
        {
            if (lift_status == 0)
            {
                //Changing the status of the list
                lift_status = 1;
                //This code tells us where thr list is on all three labels
                label1.Text = lift_status.ToString();
                label2.Text = lift_status.ToString();
                label3.Text = lift_status.ToString();
            }
            //Add the event to the Listbox

            if (rqstTop.Enabled == true)
                {
                    cartUp.Start();
                }
            }

        //request Button for the lift to go to the ground floor 

        private void button3_Click(object sender, EventArgs e)
        {
            if (lift_status == 1)
            {
                //Changing the status of the lift
                lift_status = 0;
                //This code tells us where thr list is on all three labels
                label1.Text = lift_status.ToString();
                label2.Text = lift_status.ToString();
                label3.Text = lift_status.ToString();
            }
            //Add the event to the Listbox

            if (rqstTop.Enabled == true)
            {
                cartDwn.Start();
            }
        }

        #endregion

        #region Code for control panel

        //control panel 1st floor button

        private void ctrlpn1_Click(object sender, EventArgs e)
        {
            if (lift_status == 0)
            {
                //Changing the status of the lift
                lift_status = 1;
                //This code tells us where thr list is on all three labels
                label1.Text = lift_status.ToString();
                label2.Text = lift_status.ToString();
                label3.Text = lift_status.ToString();
            }
            //Add the event to the Listbox

            if (ctrlpn1.Enabled == true)
            {
                cartUp.Start();
            }
        }

        //control panel G floor button

        private void ctrlpnG_Click(object sender, EventArgs e)
        {
            if (lift_status == 1)
            {
                //Changing the status of the lift
                lift_status = 0;
                //This code tells us where thr list is on all three labels
                label1.Text = lift_status.ToString();
                label2.Text = lift_status.ToString();
                label3.Text = lift_status.ToString();
            }
            //Add the event to the Listbox

            if (ctrlpnG.Enabled == true)
            {
                cartDwn.Start();
            }
        }

        #endregion

        #region Code That makes the lift move Up and Down

        //code that makes the lift move up
        private async void cartUp_Tick(object sender, EventArgs e)
        {
            if(cartMain.Location.Y > 28)
            {
                cartMain.Top = cartMain.Top - 1;
            }

            if(cartMain.Location.Y == 28)
            {
                string todayTime = DateTime.Now.ToString("HH:mm:ss tt");
                string todayDate = DateTime.Now.ToString("dd MMM yyyy");
                //Establish the connection of the adaptor
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =Elevator_Log_Ashley.accdb";
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from Elevator", dbconnection);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    adapter.Fill(ds);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                    //Define a new record and place it into a new DataRow
                    DataRow newRow = ds.Tables[0].NewRow();
                    newRow["Status"] = "Going to top floor";
                    newRow["StatusTime"] = todayTime;
                    newRow["StatusDate"] = todayDate;
                    newRow["StatusLift"] = lift_status;

                    //add the new DataRow to DataTable
                    ds.Tables[0].Rows.Add(newRow);

                    //Update DB
                    DataSet dataSetChanges = ds.GetChanges();
                    adapter.Update(dataSetChanges);

                    //accept changes
                    ds.AcceptChanges();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cartUp.Stop();
                await Task.Delay(2000);
                doorCls.Stop();
                doorOpn.Start();
                await Task.Delay(8000);
                doorOpn.Stop();
                doorCls.Start();
            }
        }
       

        //code that controls cart down
        private async void cartDwn_Tick(object sender, EventArgs e)
        {
            if (cartMain.Location.Y < 290)
            {
                cartMain.Top = cartMain.Top + 1;
            }

            if (cartMain.Location.Y == 290)
            {
                string todayTime = DateTime.Now.ToString("HH:mm:ss tt");
                string todayDate = DateTime.Now.ToString("dd MMM yyyy");
                //Establish the connection of the adaptor
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =Elevator_Log_Ashley.accdb";
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from Elevator", dbconnection);
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    adapter.Fill(ds);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

                    //Define a new record and place it into a new DataRow
                    DataRow newRow = ds.Tables[0].NewRow();
                    newRow["Status"] = "Going to Ground Floor";
                    newRow["StatusTime"] = todayTime;
                    newRow["StatusDate"] = todayDate;
                    newRow["StatusLift"] = lift_status;

                    //add the new DataRow to DataTable
                    ds.Tables[0].Rows.Add(newRow);

                    //update Database
                    DataSet dataSetChanges = ds.GetChanges();
                    adapter.Update(dataSetChanges);

                    //accept changes
                    ds.AcceptChanges();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cartDwn.Stop();
                await Task.Delay(2000);
                doorCls.Stop();
                doorOpn.Start();
                await Task.Delay(8000);
                doorOpn.Stop();
                doorCls.Start();
            }
        }

        #endregion

        #region Code For Opening and Closing Doors

        //Code that makes the doors open
        private void doorOpn_Tick(object sender, EventArgs e)
        {
            if (cartMain.Location.Y == 28)
            {
                if (topLeft.Location.X > 173 && topRight.Location.X < 350)
                {
                    topLeft.Left--;
                    topRight.Left++;
                }
            }

            if (cartMain.Location.Y == 290)
            {
                if (btmLeft.Location.X > 173 && btmRight.Location.X < 350)
                {
                    btmLeft.Left--;
                    btmRight.Left++;
                }
            }
        }
       
        //Code that makes the doors close
        private void doorCls_Tick(object sender, EventArgs e)
        {
            if (cartMain.Location.Y == 28)
            {
                if (topLeft.Location.X < 225 && topRight.Location.X > 298)
                {
                    topLeft.Left = topLeft.Left + 1;
                    topRight.Left = topRight.Left - 1;
                }
            }

            if (cartMain.Location.Y == 290)
            {
              if (btmLeft.Location.X < 227 && btmRight.Location.X > 298)
                {
                    btmLeft.Left++;
                    btmRight.Left--;
                    

                }
            }
        }

        #endregion

        #region Load Log Code

        //This is my Load Events Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Establish the connection and the adaptor
            string connectionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbadaptor;
            DataSet ds = new DataSet();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source=Elevator_Log_Ashley.accdb;";
            connection = new OleDbConnection(connectionString);
            try
            {
                //Opening the connection and selecting everything from Elevator (log table)
                connection.Open();
                oledbadaptor = new OleDbDataAdapter("select * from Elevator", connection);
                oledbadaptor.Fill(ds);
                oledbadaptor.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //Make change is ListView Accordingly
                    ListViewItem list = new ListViewItem(row["ElevatorID"].ToString());
                    list.SubItems.Add(row["Status"].ToString());
                    list.SubItems.Add(row["StatusDate"].ToString());
                    list.SubItems.Add(row["StatusTime"].ToString());
                    list.SubItems.Add(row["Statuslift"].ToString());
                    listView1.Items.Add(list);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Clear History Code

        //This is my Clear History Button
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        #endregion

        #region Unnecessary Code

        private void panel4_Paint(object sender, PaintEventArgs e){}

        private void panel2_Paint(object sender, PaintEventArgs e){}

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void cartMain_Paint(object sender, PaintEventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}
        
        #endregion

    }
}