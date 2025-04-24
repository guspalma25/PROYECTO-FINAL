using System;
using System.Windows.Forms;

public partial class FormUsuario : Form
{
    public FormUsuario()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Usuario usuario = new Usuario
            {
                Id = int.Parse(txtId.Text),
                NombreUsuario = txtNombreUsuario.Text,
                Contrasena = txtContrasena.Text,
                Correo = txtCorreo.Text,
                Rol = txtRol.Text,
                EstadoCuenta = chkEstadoCuenta.Checked,
                FechaRegistro = dtpFechaRegistro.Value,
                FechaUltimoAcceso = dtpFechaUltimoAcceso.Value,
                PreguntaSeguridad = txtPreguntaSeguridad.Text
            };

            MessageBox.Show("Usuario guardado correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
