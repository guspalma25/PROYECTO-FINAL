using System;
using System.Windows.Forms;

public partial class FormSucursal : Form
{
    public FormSucursal()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Sucursal sucursal = new Sucursal
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Ciudad = txtCiudad.Text,
                Pais = txtPais.Text,
                Telefono = txtTelefono.Text,
                Activa = chkActiva.Checked,
                FechaApertura = dtpFechaApertura.Value,
                NumeroEmpleados = int.Parse(txtNumeroEmpleados.Text)
            };

            MessageBox.Show("Sucursal guardada correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
