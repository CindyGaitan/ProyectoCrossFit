using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ingenieria_de_Software_Proyecto_Final
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro frmregistro = new FrmRegistro();
            frmregistro.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=mydb;Uid=root;password=Cr1st1an;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            command.CommandText = "SELECT * FROM competidor WHERE apodo='" + TxtUsuario.Text + "' AND contraseña='" + TxtContrasenia.Text + "' ";
            MySqlDataReader reader = command.ExecuteReader();


            if (reader.Read()) //Si el usuario es competidor correcto nos abrira la otra ventana.
            {
                conn.Close(); 
                this.Hide();
                FrmHome frmhome = new FrmHome();
                frmhome.Show();
            }
            else 
            {
                conn.Close();
                conn.Open();

                command.CommandText = "SELECT * FROM jefebox WHERE apodo='" + TxtUsuario.Text + "' AND contraseña='" + TxtContrasenia.Text + "' ";
                reader = command.ExecuteReader();
                if (reader.Read()) //si el usuario es jefe de box correcto nos dejara loguear
                {
                    conn.Close();
                    this.Hide();
                    FrmHome frmhome = new FrmHome();
                    frmhome.Show();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Error - Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
