using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyDBOffset
{
    public partial class UI : Form
    {
        iPersonDAO dao;

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            dao = OnDAO.ini("s");
            dataGridView1.DataSource = dao.read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dao.create(targetPerson());
            dataGridView1.DataSource = dao.read();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dao.update(targetPerson());
            dataGridView1.DataSource = dao.read();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dao.delete(targetPerson());
            dataGridView1.DataSource = dao.read();
        }

        private Person targetPerson()
        {
            int tId = Int32.Parse(txtId.Text);
            string tFName = txtFName.Text;
            string tLName = txtLName.Text;
            int tAge = Int32.Parse(txtAge.Text);
            return new Person(tId, tFName, tLName, tAge);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dao = OnDAO.ini(cmbDBType.Text);
            dataGridView1.DataSource = dao.read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
