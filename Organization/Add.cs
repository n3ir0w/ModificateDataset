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

namespace Organization
{
    public partial class Add : Form
    {
        DataSet dsZ;
        DataSet dsD;
        DataSet dsI;
        DataSet dsP;
        DataSet dsR;
        SqlDataAdapter adpZ;
        SqlDataAdapter adpD;
        SqlDataAdapter adpI;
        SqlDataAdapter adpP;
        SqlDataAdapter adpR;
        SqlCommandBuilder cmdBuild;
        SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True");
        string cmdsqlZakazchik = "select * from Заказчик";
        string cmdsqlDogovor = "select * from Договор";
        string cmdsqlIspolnitel = "select * from Исполнитель";
        string cmdsqlProekt = "select * from Проект";
        string cmdsqlRukovoditel = "select * from Руководитель";
        public Add()
        {
            InitializeComponent();

            {
                connection.Open();

                adpZ = new SqlDataAdapter(cmdsqlZakazchik, connection);
                dsZ = new DataSet();
                adpZ.Fill(dsZ);
                заказчикDataGridView.DataSource = dsZ.Tables[0];

                adpD = new SqlDataAdapter(cmdsqlDogovor, connection);
                dsD = new DataSet();
                adpD.Fill(dsD);
                договорDataGridView.DataSource = dsD.Tables[0];

                adpI = new SqlDataAdapter(cmdsqlIspolnitel, connection);
                dsI = new DataSet();
                adpI.Fill(dsI);
                исполнительDataGridView.DataSource = dsI.Tables[0];

                adpP = new SqlDataAdapter(cmdsqlProekt, connection);
                dsP = new DataSet();
                adpP.Fill(dsP);
                проектDataGridView.DataSource = dsP.Tables[0];

                adpR = new SqlDataAdapter(cmdsqlRukovoditel, connection);
                dsR = new DataSet();
                adpR.Fill(dsR);
                руководительDataGridView.DataSource = dsR.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (заказчикDataGridView.Visible == true)
            {
                DataRow rowZ = dsZ.Tables[0].NewRow();
                dsZ.Tables[0].Rows.Add(rowZ);
            }
            if (договорDataGridView.Visible == true)
            {
                DataRow rowD = dsD.Tables[0].NewRow();
                dsD.Tables[0].Rows.Add(rowD);
            }
            if (исполнительDataGridView.Visible == true)
            {
                DataRow rowI = dsI.Tables[0].NewRow();
                dsI.Tables[0].Rows.Add(rowI);
            }
           if (проектDataGridView.Visible == true)
            {
                DataRow rowP = dsP.Tables[0].NewRow();
                dsP.Tables[0].Rows.Add(rowP);
            }
           if (руководительDataGridView.Visible == true)
            {
                DataRow rowR = dsR.Tables[0].NewRow();
                dsR.Tables[0].Rows.Add(rowR);
            } 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True"))
            {
                connection.Open();
                adpZ = new SqlDataAdapter(cmdsqlZakazchik, connection);
                cmdBuild = new SqlCommandBuilder(adpZ);
                adpZ.Update(dsZ);
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True"))
            {
                connection.Open();
                adpD = new SqlDataAdapter(cmdsqlDogovor, connection);
                cmdBuild = new SqlCommandBuilder(adpD);
                adpD.Update(dsD);
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True"))
            {
                connection.Open();
                adpI = new SqlDataAdapter(cmdsqlIspolnitel, connection);
                cmdBuild = new SqlCommandBuilder(adpI);
                adpI.Update(dsI);
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True"))
            {
                connection.Open();
                adpP = new SqlDataAdapter(cmdsqlProekt, connection);
                cmdBuild = new SqlCommandBuilder(adpP);
                adpP.Update(dsP);
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True"))
            {
                connection.Open();
                adpR = new SqlDataAdapter(cmdsqlRukovoditel, connection);
                cmdBuild = new SqlCommandBuilder(adpR);
                adpR.Update(dsR);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            договорDataGridView.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            договорDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            заказчикDataGridView.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказчикDataGridView.Visible = false;
            договорDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            исполнительDataGridView.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказчикDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            договорDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            проектDataGridView.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            заказчикDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            договорDataGridView.Visible = false;

            руководительDataGridView.Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in заказчикDataGridView.SelectedRows)
            {
                заказчикDataGridView.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in договорDataGridView.SelectedRows)
            {
                договорDataGridView.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in исполнительDataGridView.SelectedRows)
            {
                исполнительDataGridView.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in проектDataGridView.SelectedRows)
            {
                проектDataGridView.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in руководительDataGridView.SelectedRows)
            {
                руководительDataGridView.Rows.Remove(row);
            }
        }
    }
}
