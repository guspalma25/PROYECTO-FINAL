using System;
using System.Windows.Forms;

public partial class FormInventario : Form
{
    public FormInventario()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Inventario inventario = new Inventario
            {
                Id = int.Parse(txtId.Text),
                VideojuegoId = int.Parse(txtVideojuegoId.Text),
                CantidadDisponible = int.Parse(txtCantidadDisponible.Text),
                FechaUltimaActualizacion = dtpFechaActualizacion.Value,
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text),
                Estado = txtEstado.Text,
                Ubicacion = txtUbicacion.Text,
                SucursalId = int.Parse(txtSucursalId.Text),
                Observaciones = txtObservaciones.Text
            };

            MessageBox.Show("Registro de inventario guardado correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
