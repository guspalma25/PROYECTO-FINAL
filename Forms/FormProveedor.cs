using System;
using System.Windows.Forms;

public partial class FormProveedor : Form
{
    public FormProveedor()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Proveedor proveedor = new Proveedor
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Contacto = txtContacto.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Pais = txtPais.Text,
                Ciudad = txtCiudad.Text,
                TipoProveedor = txtTipoProveedor.Text
            };

            MessageBox.Show("Proveedor guardado correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
