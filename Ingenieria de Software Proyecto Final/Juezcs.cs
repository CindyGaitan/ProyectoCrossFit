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
using System.Data.SqlClient;

namespace Ingenieria_de_Software_Proyecto_Final
{
    
    public partial class Juezcs : Form
    {
        string connString = "Server=localhost;Port=3306;Database=mydb;Uid=root;password='';";
        int Id_Juez;       
        public Juezcs()
        {
            
            InitializeComponent();
        }

    
        public void Limpiar()
        {
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            CbxAcreditacion.Checked = false;
            ChbEstado.Checked = false;
            Id_Juez = 0;
            Mostrar();

        }

        public void Mostrar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();    
                MySqlCommand mostrar = new MySqlCommand("select Id_Juez, NombresJuez as Nombres, ApellidosJuez as Apellidos, case Id_Acreditacion when 1 then 'SI' else 'NO'end as Acreditacion, case Estado when 1 then 'ACTIVO' else 'INACTIVO'end as Estado from juez; ", conn);

                MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
                DataSet ds = new DataSet();
                m_datos.Fill(ds);

                DtgVJuez.DataSource = ds.Tables[0];
                DtgVJuez.Columns[0].Visible = false;
                conn.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al mostrar datos.");
            }
        }

        public void Eliminar()
        {
            try
            {
                int BlnAcreditacion;
                int BlnEstado;

                if (CbxAcreditacion.Checked)
                {
                    BlnAcreditacion = 1;
                }
                else
                {
                    BlnAcreditacion = 0;
                }

                if (ChbEstado.Checked)
                {
                    BlnEstado = 1;
                }
                else
                {
                    BlnEstado = 0;
                }


                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                string query = " update Juez set Estado = 0 where Id_Juez = @Id_Juez; ";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.Add("@Id_Juez", MySqlDbType.Int32).Value = Id_Juez;
                command.ExecuteNonQuery();

                MessageBox.Show("Eliminación Exitosa.");
                Mostrar();
                Limpiar();
                conn.Close();


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al realizar la eliminación.");
            }
        }

        public void Modificar()
        {
            try
            {
                int BlnAcreditacion;
                int BlnEstado;

                if (CbxAcreditacion.Checked)
                {
                    BlnAcreditacion = 1;
                }
                else
                {
                    BlnAcreditacion = 0;
                }

                if (ChbEstado.Checked)
                {
                    BlnEstado = 1;
                }
                else
                {
                    BlnEstado = 0;
                }


                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                string query = " update Juez set NombresJuez = @NombresJuez, ApellidosJuez = @ApellidosJuez, Id_Acreditacion = @Id_Acreditacion, Estado = @Estado where Id_Juez = @Id_Juez; ";

                MySqlCommand command = new MySqlCommand(query, conn);


                command.Parameters.Add("@NombresJuez", MySqlDbType.VarChar).Value = TxtNombres.Text;
                command.Parameters.Add("@ApellidosJuez", MySqlDbType.VarChar).Value = TxtApellidos.Text;
                command.Parameters.Add("@Id_Acreditacion", MySqlDbType.Bit).Value = BlnAcreditacion;
                command.Parameters.Add("@Estado", MySqlDbType.Bit).Value = BlnEstado;
                command.Parameters.Add("@Id_Juez", MySqlDbType.Int32).Value = Id_Juez;
                command.ExecuteNonQuery();

                MessageBox.Show("Modificacion Exitosa.");
                Mostrar();
                Limpiar();
                conn.Close();
                

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al realizar la modificación.");
            }
        }
        

        public void Ingresar()
        {
            try
            {
                int BlnAcreditacion;
                int BlnEstado;
                int Id_Juez;

                if (CbxAcreditacion.Checked)
                {
                    BlnAcreditacion = 1;
                }
                else
                {
                    BlnAcreditacion = 0;
                }

                if (ChbEstado.Checked)
                {
                    BlnEstado = 1;
                }
                else
                {
                    BlnEstado = 0;
                }


                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                string query1 = "select ifnull(max(id_juez)+1,0) as id from juez;";
                MySqlCommand cmd = new MySqlCommand(query1, conn);

                Id_Juez = Convert.ToInt32(cmd.ExecuteScalar());

                string query = " insert into juez (Id_Juez, NombresJuez, ApellidosJuez, Id_Acreditacion, Estado) values( @id, @NombresJuez, @ApellidosJuez, @Id_Acreditacion, @Estado);";

                MySqlCommand command = new MySqlCommand(query, conn);


                command.Parameters.Add("@NombresJuez", MySqlDbType.VarChar).Value = TxtNombres.Text;
                command.Parameters.Add("@ApellidosJuez", MySqlDbType.VarChar).Value = TxtApellidos.Text;
                command.Parameters.Add("@Id_Acreditacion", MySqlDbType.Bit).Value = BlnAcreditacion;
                command.Parameters.Add("@Estado", MySqlDbType.Bit).Value = BlnEstado;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id_Juez;
                command.ExecuteNonQuery();

                MessageBox.Show("Registro Exitoso");
                Mostrar();
                Limpiar();
                conn.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al realizar el ingreso.");
            }

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Juezcs_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void DtgVJuez_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Estado;
            string Acreditacion;

            Id_Juez = Convert.ToInt32(DtgVJuez.CurrentRow.Cells["id_Juez"].Value.ToString());
            TxtNombres.Text = DtgVJuez.CurrentRow.Cells["Nombres"].Value.ToString();
            TxtApellidos.Text = DtgVJuez.CurrentRow.Cells["Apellidos"].Value.ToString();
            Estado = DtgVJuez.CurrentRow.Cells["Estado"].Value.ToString();
            Acreditacion = DtgVJuez.CurrentRow.Cells["Acreditacion"].Value.ToString();

            if (Estado == "ACTIVO")
            {
                ChbEstado.Checked = true;
            }
            else
            {
                ChbEstado.Checked = false;
            }

            if (Acreditacion == "SI")
            {
                CbxAcreditacion.Checked = true;
            }
            else
            {
                CbxAcreditacion.Checked = false;
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
