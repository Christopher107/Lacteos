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
    public partial class RegistroHoras : Form
    {

        private HorasExtras _horasExtras;

        public RegistroHoras()
        {
            InitializeComponent();
        }

        private void RegistroHoras_Load(object sender, EventArgs e)
        {
            cbxBuscHora.ValueMember = "Rut";
            cbxBuscHora.DisplayMember = "Nombre";

            cbxRutHoras.ValueMember = "Rut";

            CargarComboBox();

            CargarUsuario();

            CargarGrilla();
            Botones(true);
        }

        private void CargarUsuario()
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxBuscHora.DataSource = contexto.Trabajador.ToList();
                cbxRutHoras.DataSource = contexto.Trabajador.ToList();
            }
        }

        private void Limpiar()
        {
            txtHorasRealizadas.Clear();
        }
        private void Botones(bool estado)
        {
            btnGuardarHoras.Enabled = estado;
            btnActualizarHoras.Enabled = !estado;
            btnBorrarHoras.Enabled = !estado;
        }

        private void CargarGrilla()
        {
            dgvHoras.Rows.Clear();
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                List<HorasExtras> registroHoras = contexto.HorasExtras.ToList();

                foreach (HorasExtras item in registroHoras)
                {
                    dgvHoras.Rows.Add(new object[]
                    {
                       item.Id,
                       item.Rut,
                       item.HorasExtras1,
                       item.Fecha,
                    });
                }
            }
        }

        private void CargarComboBox()
        {

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                cbxBuscHora.DataSource = contexto.Trabajador.ToList();
                cbxRutHoras.DataSource = contexto.Trabajador.ToList();
            }
        }

        private void Guardar()
        {
            _horasExtras = new HorasExtras()
            {
                Rut = Convert.ToInt32(cbxRutHoras.Text),
                Fecha = dtFechaHoras.Value,
                HorasExtras1 = Convert.ToInt32(txtHorasRealizadas.Text),
            };

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.HorasExtras.Add(_horasExtras);
                contexto.SaveChanges();
            }
            MessageBox.Show(
                $"Se añadio la hora {_horasExtras.HorasExtras1} al Rut {_horasExtras.Rut} exitosamente",
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
            _horasExtras.Fecha = dtFechaHoras.Value;
            _horasExtras.HorasExtras1 = Convert.ToInt32(txtHorasRealizadas.Text);

            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                contexto.Entry(_horasExtras).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            MessageBox.Show(
                            $"Se edito la informacion relacionada al Rut {_horasExtras.Rut} exitosamente",
                            ".: Sistema Horas Extras:.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
            CargarGrilla();
            Limpiar();
            Botones(true);
        }

        private void Eliminar()
        {
            if (cbxRutHoras.ValueMember =="")
            {
                MessageBox.Show("Por favor seleccione el Rut que desea borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                            "Esta seguro de eliminar al Rut" + Rut + "Del sistema",
                            "Borrar", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                if (resultado == DialogResult.Yes)
                {
                    using (var contexto = new HorasExtrasLacteosOsornoEntities())
                    {
                        contexto.HorasExtras.Attach(_horasExtras);
                        contexto.HorasExtras.Remove(_horasExtras);
                        contexto.SaveChanges();
                    }
                    CargarGrilla();
                    Botones(true);
                    MessageBox.Show(
                                   "Se a eliminado al Rut " + Rut + "Del sistema",
                                   "Borrado exitoso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
                else
                {
                    MessageBox.Show(
                                    "Se cancelo la operacion borrar al Rut" + Rut + "Del sistema",
                                    "Borrado cancelado", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                }
            }
        }

        private void dgvHoras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                int Id = Convert.ToInt32(
                                        dgvHoras
                                        .Rows[index]
                                        .Cells[0]
                                        .Value
                                        .ToString()
                                        );
                using (var contexto = new HorasExtrasLacteosOsornoEntities())
                {
                    _horasExtras = contexto.HorasExtras.Find(Id);

                    cbxRutHoras.SelectedValue = _horasExtras.Rut.ToString();
                    dtFechaHoras.Value = _horasExtras.Fecha.GetValueOrDefault();
                    txtHorasRealizadas.Text = _horasExtras.HorasExtras1.ToString();

                    Botones(false);
                }
            }
        }

        private void btnGuardarHoras_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnActualizarHoras_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnBorrarHoras_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnBuscarHoras_Click(object sender, EventArgs e)
        {
            using (HorasExtrasLacteosOsornoEntities contexto = new HorasExtrasLacteosOsornoEntities())
            {
                dgvHoras.Rows.Clear();

                int Rut = Convert.ToInt32(cbxBuscHora.SelectedValue);
                List<HorasExtras> listar = contexto.HorasExtras.Where(x => x.Rut == Rut).ToList();
                foreach (var item in listar)
                {
                    dgvHoras.Rows.Add(new object[] {
                           item.Id,
                           item.Rut,
                           item.Fecha,
                           item.HorasExtras1,
                    });
                }
            }
        }
    }
}
