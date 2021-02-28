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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            SqlConnection CN = new SqlConnection();
             
            CN.ConnectionString = @"Data Source=.\SQL_UAI;Initial Catalog=Empleados;Integrated Security=True";
            CN.Open();
            SqlDataAdapter DA = new SqlDataAdapter("Select * from Empleado", CN );
            DA.Fill(DS, "Empleado");
            CN.Close();
            DS.WriteXml("D:\\Empleado.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Frm = new XML.Form2();
            Frm.Show();
        }
    }
}
