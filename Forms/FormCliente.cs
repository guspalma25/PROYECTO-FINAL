using System;
using System.Windows.Forms;

public partial class FormCliente : Form
{
    public FormCliente()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Cliente cliente = new Cliente
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Edad = int.Parse(txtEdad.Text),
                Genero = cmbGenero.SelectedItem?.ToString() ?? "",
                FechaRegistro = dtpFechaRegistro.Value,
                Estado = chkActivo.Checked
            };

            MessageBox.Show($"Cliente guardado:\nNombre: {cliente.Nombre}\nCorreo: {cliente.Correo}");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
