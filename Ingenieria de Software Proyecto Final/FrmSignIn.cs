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

    public partial class FrmSignIn : Form
    {
        
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {
            //String de conexion 
            string connString = "Server=localhost;Port=3306;Database=mydb;Uid=root;password=Cr1st1an;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

            //vaciar combo box
            CBPais.Items.Clear();
            CBPais.ResetText();

            CBGym.Items.Clear();
            CBGym.ResetText();

            CBCoJ.Items.Clear();
            CBCoJ.ResetText();

            try
            {
                conn.Open();
                //autollenado de ComboBox para pais y gimnasio para eleccion
                command.CommandText = "select Id_Pais, Pais from paises";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dtPais = new DataTable();
                dtPais.Columns.Add("Id_Pais", typeof(string));
                dtPais.Columns.Add("Pais", typeof(string));
                dtPais.Load(reader);

                CBPais.ValueMember = "Id_Pais";
                CBPais.DisplayMember = "Pais";
                CBPais.DataSource = dtPais;

                conn.Close();

                conn.Open();

                command.CommandText = "select Id_Gimnasio, Gimnasio from gimnasio";
                reader= command.ExecuteReader();

                DataTable dtGym = new DataTable();
                dtGym.Columns.Add("Id_Gimnasio", typeof(string));
                dtGym.Columns.Add("Gimnasio", typeof(string));
                dtGym.Load(reader);

                CBGym.ValueMember = "Id_Gimnasio";
                CBGym.DisplayMember = "Gimnasio";
                CBGym.DataSource = dtGym;

                conn.Close();

                CBCoJ.Items.Add("competidor");
                CBCoJ.Items.Add("jefebox");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Registro de usuario con los usuarios y datos seleccionados
            string connString = "Server=localhost;Port=3306;Database=mydb;Uid=root;password=Cr1st1an;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            CBPais.ValueMember.ToString();
            CBGym.ValueMember.ToString();
            command.CommandText = "insert into " + CBCoJ.Text + " (Apodo, contraseña, Nombres, Apellidos, Id_PaisOrigen, Id_Gimnasio, FechaNacimiento, Estado, Id_Acreditacion) values('" + TxtApodo.Text + "', '" + TxtContraseña.Text + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "'," + CBPais.SelectedValue.ToString() + "," + CBGym.SelectedValue.ToString() + ",'" + CBFecha.Text + "',1," + TxtAcreditaciones.Text + ")";
            
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario registrado");
                this.Hide();
                FrmLogin frmlogin = new FrmLogin();
                frmlogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                       
        }

        private void CBPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBCoJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
