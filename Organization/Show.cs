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
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
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

        private void Show_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Руководитель". При необходимости она может быть перемещена или удалена.
            this.руководительTableAdapter.Fill(this.organizationDataSet.Руководитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Проект". При необходимости она может быть перемещена или удалена.
            this.проектTableAdapter.Fill(this.organizationDataSet.Проект);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Исполнитель". При необходимости она может быть перемещена или удалена.
            this.исполнительTableAdapter.Fill(this.organizationDataSet.Исполнитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.organizationDataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.organizationDataSet.Договор);

        }

        private void договорBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договорBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.organizationDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            договорDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            заказчикDataGridView.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказчикDataGridView.Visible = false;
            исполнительDataGridView.Visible = false;
            проектDataGridView.Visible = false;
            руководительDataGridView.Visible = false;

            договорDataGridView.Visible = true;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }
    }
}
