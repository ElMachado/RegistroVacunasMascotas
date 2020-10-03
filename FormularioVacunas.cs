using System;
using System.Windows.Forms;

namespace ProgramaMascotas
{
    public partial class FormularioVacunas : Form
    {
        public FormularioVacunas()
        {
            InitializeComponent();
        }

        private void ActualizaComboBoxMascotas()
        {
            comboBoxMascotas.DataSource = null;
            comboBoxMascotas.DataSource = AccesoDatos.ObtenerMascotas();

            comboBoxMascotas.DisplayMember = "Mascotas";
            //selecciona la primera mascota de la lista
            //comboBoxMascotas.SelectedIndex = 0;
        }

        private void ActualizaComboBoxVacunas()
        {
            var id_mascota = comboBoxMascotas.SelectedItem.ToString();

            comboBoxVacunas.DataSource = null;
            comboBoxVacunas.DataSource = AccesoDatos.ObtenerVacunasPorEspecies(id_mascota);
        }

        private void FormVacunas_Load(object sender, EventArgs e)
        {
            ActualizaComboBoxMascotas();
            InicializaVisualizacionDatos();
            ActualizaComboBoxVacunas();
        }

        private void InicializaVisualizacionDatos()
        {
            InicializaDataGridViewInfoMascotas();
            InicializaDataGridViewInfoVacunasRazaEspecie();
            InicializaDataGridViewInfoMascotasPorVacunaEspecie();
        }

        private void InicializaDataGridViewInfoMascotas()
        {
            dataGridViewInfoMascota.DataSource = null;
            dataGridViewInfoMascota.DataSource = AccesoDatos.ObtenerInfoMascotas();
        }

        private void InicializaDataGridViewInfoVacunasRazaEspecie()
        {
            dataGridViewCantidadRazaEspecie.DataSource = null;
            dataGridViewCantidadRazaEspecie.DataSource = AccesoDatos.ObtenerInfoVacunasRazaEspecie();
        }

        private void InicializaDataGridViewInfoMascotasPorVacunaEspecie()
        {
            dataGridViewCantidadVacunaEspecie.DataSource = null;
            dataGridViewCantidadVacunaEspecie.DataSource = AccesoDatos.ObtenerInfoMascotasPorVacunaEspecie();
        }

        private void comboBoxMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizaComboBoxVacunas();
        }

        private void buttonRegistrarVacuna_Click(object sender, EventArgs e)
        {
            var id_mascota = comboBoxMascotas.SelectedItem.ToString();
            var vacuna = comboBoxVacunas.SelectedItem.ToString();
            var fecha_vacunacion = dateTimePicker1.Value.ToString();

            if (AccesoDatos.InsertarRegistroVacunacion(id_mascota, vacuna, fecha_vacunacion))
            {
                InicializaVisualizacionDatos();
            }
        }
    }
}