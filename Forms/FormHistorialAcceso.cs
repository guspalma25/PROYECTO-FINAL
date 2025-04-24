using System;
using System.Windows.Forms;

public partial class FormHistorialAcceso : Form
{
    public FormHistorialAcceso()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            HistorialAcceso historial = new HistorialAcceso
            {
                Id = int.Parse(txtId.Text),
                UsuarioId = int.Parse(txtUsuarioId.Text),
                FechaAcceso = dtpFechaAcceso.Value,
                IP = txtIP.Text,
                Dispositivo = txtDispositivo.Text,
                Ubicacion = txtUbicacion.Text,
                Accion = txtAccion.Text,
                Resultado = txtResultado.Text,
                Descripcion = txtDescripcion.Text
            };

            MessageBox.Show("Acceso registrado correctamente");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
