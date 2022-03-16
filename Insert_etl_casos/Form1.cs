using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;


using System.Data.SqlClient;

using System.Windows.Forms;

namespace Insert_etl_casos
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
         
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-R11EBV1\SQLEXPRESS03;Initial Catalog=BD_CRM_INTERMEDIO_DES;Integrated Security=True");
            conexion.Open();
           string nombre = "Juan perez";
           string mensaje = "Mensaje Nro";
            string correo = "dariomedina10@gmail.com";
            string correo2 = "ysma@gmail.com";
            string periodo = "2022";
            string vacio = "";
            int i=1;

            while (i<=500000) { 
            string cadena = "insert into crm_casos values (" + i + "," + i + ",'" + mensaje +   vacio + i + "','" + nombre + "','" + correo + "','" + periodo + "','" + vacio + "','" + vacio + "','" + vacio + "','" + vacio + "','" + vacio + "','" + vacio + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
                i++;
            }
            MessageBox.Show("Los datos se guardaron correctamente");
          //  textBox1.Text = "";
          // textBox2.Text = "";
            conexion.Close();
        }
    }
}
