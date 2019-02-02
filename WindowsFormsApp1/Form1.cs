using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistroUsuarios : Form
    {
        private Usuarios _usuario;

        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void CargarUsuario()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxBuscUsuario.DataSource = contexto.Usuarios.ToList();
            }
        }

        private void Limpiar()
        {
            txtRegUsuario.Clear();
            txtRegClave.Clear();
            Botones(true);
        }
        private void Botones(bool estado)
        {
            GuardarUsuario.Enabled = estado;
            ActualizarUsuario.Enabled = !estado;
            BorrarUsuario.Enabled = !estado;
        }

        private void CargarGrilla()
        {
            dgvUsuarios.Rows.Clear();
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                List<Usuarios> registroUsuarios = contexto.Usuarios.ToList();

                foreach (Usuarios item in registroUsuarios)
                {
                    dgvUsuarios.Rows.Add(new object[]
                    {
                       item.Id,
                       item.Usuario,
                       item.Clave,
                       item.TipoUsuario,
                    });
                }
            }
        }

        private void CargarComboBox()
        {

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxBuscUsuario.DataSource = contexto.Usuarios.ToList();
            }
        }

        private void Guardar()
        {
            _usuario = new Usuarios()
            {
                Usuario = Convert.ToInt32(txtRegUsuario.Text),
                Clave = txtRegClave.Text,
                TipoUsuario = cbxRegTipoUsuario.Text,
            };

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.Usuarios.Add(_usuario);
                contexto.SaveChanges();
            }
            MessageBox.Show(
                $"Se guardo el usrio {_usuario.Usuario} exitosamente",
                ".: Sistema Horas:.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            CargarComboBox();
            CargarGrilla();
            Limpiar();
        }

        private void Editar()
        { 
            _usuario.Usuario = Convert.ToInt32(txtRegUsuario.Text);
            _usuario.Clave = txtRegClave.Text;
            _usuario.TipoUsuario = cbxRegTipoUsuario.Text;


            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.Entry(_usuario).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            MessageBox.Show(
                            $"Se edito la informacion del cliente {_usuario.Usuario} exitosamente",
                            ".: Sistema Veterinaria:.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
            CargarGrilla();
            Limpiar();
            Botones(true);
        }

        private void Eliminar()
        {
            if (txtRegUsuario.Text == "")
            {
                MessageBox.Show("Por favor seleccione el usuario que desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                            "Esta seguro de eliminar a" + Usuario + "Del sistema",
                            "Borrar", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                if (resultado == DialogResult.Yes)
                {
                    using (var contexto = new HorasExtrasLacteosOsornoEntities())
                    {
                        contexto.Usuarios.Attach(_usuario);
                        contexto.Usuarios.Remove(_usuario);
                        contexto.SaveChanges();
                    }
                    CargarGrilla();
                    Botones(true);
                    MessageBox.Show(
                                   "Se aeliminado a" + Usuario + "Del sistema",
                                   "Borrado exitoso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
                else
                {
                    MessageBox.Show(
                                    "Se cancelo la operacion borrar a" + Usuario + "Del sistema",
                                    "Borrado cancelado", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
            }
        }

        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void ActualizarUsuario_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BorrarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BuscarUsuario_Click(object sender, EventArgs e)
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {               
                dgvUsuarios.Rows.Clear();

                int Usuario = Convert.ToInt32(cbxBuscUsuario.SelectedValue);
                List<Usuarios> listar = contexto.Usuarios.Where(x => x.Usuario == Usuario).ToList();
                foreach (var item in listar)
                {
                    dgvUsuarios.Rows.Add(new object[] {
                           item.Id,
                           item.Usuario,
                           item.Clave,
                           item.TipoUsuario,
                    });
                }
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            cbxBuscUsuario.ValueMember = "Usuario";

            CargarComboBox();

            CargarUsuario();

            CargarGrilla();
            Botones(true);
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int Id = Convert.ToInt32(
                                        dgvUsuarios
                                        .Rows[index]
                                        .Cells[0]
                                        .Value
                                        .ToString()
                                        );
                using (var contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    _usuario = contexto.Usuarios.Find(Id);

                    txtRegUsuario.Text = _usuario.Usuario.ToString();
                    txtRegClave.Text = _usuario.Clave;
                    cbxRegTipoUsuario.SelectedValue = _usuario.TipoUsuario;

                    Botones(false);
                }
            }
        }
    }
}
