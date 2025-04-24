using System;
using System.Windows.Forms;

public partial class FormDetalleVenta : Form
{
    public FormDetalleVenta()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            DetalleVenta detalle = new DetalleVenta
            {
                Id = int.Parse(txtId.Text),
                VentaId = int.Parse(txtVentaId.Text),
                VideojuegoId = int.Parse(txtVideojuegoId.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text),
                Subtotal = decimal.Parse(txtSubtotal.Text),
                Descuento = decimal.Parse(txtDescuento.Text),
                Total = decimal.Parse(txtTotal.Text),
                Fecha = dtpFecha.Value
            };

            MessageBox.Show($"Detalle guardado:\nTotal: {detalle.Total:C}");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
