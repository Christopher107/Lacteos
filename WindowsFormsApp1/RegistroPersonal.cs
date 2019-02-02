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
    public partial class RegistroPersonal : Form
    {
        private Trabajador _trabajador;

        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void RegistroPersonal_Load(object sender, EventArgs e)
        {
            cbxRut.ValueMember = "Rut";
            cbxRut.DisplayMember = "Nombre";

            cbxNombre.ValueMember = "Nombre";
            cbxApellido.ValueMember = "Apellido";

            CargarComboBox();

            CargarTrabajador();

            CargarGrilla();
            Botones(true);
        }

        private void CargarTrabajador()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxRut.DataSource = contexto.Trabajador.ToList();
                cbxNombre.DataSource = contexto.Trabajador.ToList();
                cbxApellido.DataSource = contexto.Trabajador.ToList();
               
            }
        }

        private void Limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTurno.Clear();
            Botones(true);
        }
        private void Botones(bool estado)
        {
            btnGuardarPersonal.Enabled = estado;
            btnActualizarPersonal.Enabled = !estado;
            btnBorrarPersonal.Enabled = !estado;
        }

        private void CargarGrilla()
        {
            dgvPersonal.Rows.Clear();
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                List<Trabajador> registroPersonal = contexto.Trabajador.ToList();

                foreach (Trabajador item in registroPersonal)
                {
                    dgvPersonal.Rows.Add(new object[]
                    {
                       item.Rut,
                       item.Nombre,
                       item.Apellido,
                       item.Seccion,
                       item.FechaIngreso,
                       item.Turno
                    });
                }
            }
        }

        private void CargarComboBox()
        {

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxRut.DataSource = contexto.Trabajador.ToList();
                cbxNombre.DataSource = contexto.Trabajador.ToList();
                cbxApellido.DataSource = contexto.Trabajador.ToList();
            }
        }

        private void Guardar()
        {
            _trabajador = new Trabajador()
            {
                Rut = Convert.ToInt32(txtRut.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaIngreso = dtIngreso.Value,
                Seccion = Convert.ToInt32(cbxSeccion.Text),
                Turno = txtTurno.Text,
            };

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.Trabajador.Add(_trabajador);
                contexto.SaveChanges();
            }
            MessageBox.Show(
                $"Se guardo el usrio {_trabajador.Nombre} exitosamente",
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
            _trabajador.Rut = Convert.ToInt32(txtRut.Text);
            _trabajador.Nombre = txtNombre.Text;
            _trabajador.Apellido = txtApellido.Text;
            _trabajador.FechaIngreso = dtIngreso.Value;
            _trabajador.Seccion = Convert.ToInt32(cbxSeccion.Text);
            _trabajador.Turno = txtTurno.Text;


            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.Entry(_trabajador).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            MessageBox.Show(
                            $"Se edito la informacion del cliente {_trabajador.Nombre} exitosamente",
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
            if (txtRut.Text == "")
            {
                MessageBox.Show("Por favor seleccione el Rut del trabajador que desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                            "Esta seguro de eliminar a" + Rut + "Del sistema",
                            "Borrar", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                if (resultado == DialogResult.Yes)
                {
                    using (var contexto = new HorasExtrasLacteosOsornoEntities())
                    {
                        contexto.Trabajador.Attach(_trabajador);
                        contexto.Trabajador.Remove(_trabajador);
                        contexto.SaveChanges();
                    }
                    CargarGrilla();
                    Botones(true);
                    MessageBox.Show(
                                   "Se aeliminado a" + Nombre + "Del sistema",
                                   "Borrado exitoso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
                else
                {
                    MessageBox.Show(
                                    "Se cancelo la operacion borrar a" + Nombre + "Del sistema",
                                    "Borrado cancelado", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
            }
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnBorrarPersonal_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            if (chkRut.Checked)
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();

                    int Rut = Convert.ToInt32(cbxRut.SelectedValue);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Rut == Rut).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                               item.Turno,
                        });
                    }
                }
            }else if (chkNombre.Checked)
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();
                    String Nombre = Convert.ToString(cbxNombre.Text);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Nombre == Nombre).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                               item.Turno,
                        });
                    }
                }
            }
            else
            {
                using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    dgvPersonal.Rows.Clear();
                    String Apellido = Convert.ToString(cbxApellido.Text);
                    List<Trabajador> listar = contexto.Trabajador.Where(x => x.Apellido == Apellido).ToList();
                    foreach (var item in listar)
                    {
                        dgvPersonal.Rows.Add(new object[] {
                               item.Rut,
                               item.Nombre,
                               item.Apellido,
                               item.FechaIngreso,
                               item.Seccion,
                               item.Turno,
                        });
                    }
                }
            }
        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int Rut = Convert.ToInt32(
                                        dgvPersonal
                                        .Rows[index]
                                        .Cells[0]
                                        .Value
                                        .ToString()
                                        );
                using (var contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    _trabajador = contexto.Trabajador.Find(Rut);

                    txtRut.Text = _trabajador.Rut.ToString();
                    txtNombre.Text = _trabajador.Nombre;
                    txtApellido.Text = _trabajador.Apellido;
                    dtIngreso.Value = _trabajador.FechaIngreso.GetValueOrDefault();
                    cbxSeccion.SelectedValue = _trabajador.Seccion.ToString();
                    txtTurno.Text = _trabajador.Turno;

                    Botones(false);
                }
            }
        }


        private void chkRut_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = true;
            cbxNombre.Enabled = false;
            cbxApellido.Enabled = false;
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = false;
            cbxNombre.Enabled = true;
            cbxApellido.Enabled = false;
        }

        private void chkApellido_CheckedChanged(object sender, EventArgs e)
        {
            cbxRut.Enabled = false;
            cbxNombre.Enabled = false;
            cbxApellido.Enabled = true;
        }
    }
}
