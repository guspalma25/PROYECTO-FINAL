using System;
using System.Windows.Forms;

public partial class FormVenta : Form
{
    public FormVenta()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Venta venta = new Venta
            {
                Id = int.Parse(txtId.Text),
                ClienteId = int.Parse(txtClienteId.Text),
                FechaVenta = dtpFechaVenta.Value,
                Total = decimal.Parse(txtTotal.Text),
                MetodoPago = txtMetodoPago.Text,
                Estado = txtEstado.Text,
                Descuento = decimal.Parse(txtDescuento.Text),
                TipoVenta = txtTipoVenta.Text,
                EmpleadoId = int.Parse(txtEmpleadoId.Text)
            };

            MessageBox.Show("Venta guardada correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
