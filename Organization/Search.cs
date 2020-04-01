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
    public partial class Search : Form
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
        public Search()
        {
            InitializeComponent();

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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (заказчикDataGridView.Visible == true)
            {
                for (int i = 0; i < заказчикDataGridView.RowCount; i++)
                {
                    заказчикDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < заказчикDataGridView.ColumnCount; j++)
                        if (заказчикDataGridView.Rows[i].Cells[j].Value != null)
                            if (заказчикDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                заказчикDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (договорDataGridView.Visible == true)
            {
                for (int i = 0; i < договорDataGridView.RowCount; i++)
                {
                    договорDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < договорDataGridView.ColumnCount; j++)
                        if (договорDataGridView.Rows[i].Cells[j].Value != null)
                            if (договорDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                договорDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (исполнительDataGridView.Visible == true)
            {
                for (int i = 0; i < исполнительDataGridView.RowCount; i++)
                {
                    исполнительDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < исполнительDataGridView.ColumnCount; j++)
                        if (исполнительDataGridView.Rows[i].Cells[j].Value != null)
                            if (исполнительDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                исполнительDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (проектDataGridView.Visible == true)
            {
                for (int i = 0; i < проектDataGridView.RowCount; i++)
                {
                    проектDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < проектDataGridView.ColumnCount; j++)
                        if (проектDataGridView.Rows[i].Cells[j].Value != null)
                            if (проектDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                проектDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            if (руководительDataGridView.Visible == true)
            {
                for (int i = 0; i < руководительDataGridView.RowCount; i++)
                {
                    руководительDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < руководительDataGridView.ColumnCount; j++)
                        if (руководительDataGridView.Rows[i].Cells[j].Value != null)
                            if (руководительDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                руководительDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            searchTextBox.ForeColor = Color.Black;
        }
    }
}
