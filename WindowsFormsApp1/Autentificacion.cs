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

namespace WindowsFormsApp1
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //creando la conexion
                SqlConnection miConecion = new SqlConnection("Data Source=.;Initial Catalog=GOURSYSTEM;Integrated Security=True");
                //abriendo conexion
                miConecion.Open();

                SqlCommand comando = new SqlCommand("select Nick, Pass from Usuario where Nick = '" + txtUsuario.Text + "'And Pass = '" + txtContraseña.Text + "'And Area = '" + cbxArea.Text + "' ", miConecion);

                //ejecuta una instruccion de sql devolviendo el numero de las filas afectadas
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                //Llenando el dataAdapter
                da.Fill(ds, "GourSystem");
                //utilizado para representar una fila de la tabla q necesitas en este caso usuario
                DataRow DR;
                DR = ds.Tables["GourSystem"].Rows[0];

                //evaluando que la contraseña,usuario y area sean correctos
                if ((txtUsuario.Text == DR["Nick"].ToString()) || (txtContraseña.Text == DR["Pass"].ToString()) || (cbxArea.Text == DR["Area"].ToString()))
                {
                    //instanciando el formulario principal
                    //Administrativo frmPrincipal = new Administrativo();
                    //frmPrincipal.Show();//abriendo el formulario principal
                    this.Hide();//esto sirve para ocultar el formulario de login

                }
            }
            catch
            {

                MessageBox.Show("Error! Su usuario o contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
