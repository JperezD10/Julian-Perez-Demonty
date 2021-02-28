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

namespace XML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DS.ReadXml("D:\\Empleado.xml");
            dataGridView1.DataSource = DS;
            dataGridView1.DataMember = "Empleado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            
        }
    }
}
