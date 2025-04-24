using System;
using System.Windows.Forms;

public partial class FormMetodoPago : Form
{
    public FormMetodoPago()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            MetodoPago metodo = new MetodoPago
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Activo = chkActivo.Checked,
                Comision = decimal.Parse(txtComision.Text),
                TipoPago = txtTipoPago.Text,
                Codigo = txtCodigo.Text,
                Moneda = txtMoneda.Text,
                FechaCreacion = dtpFechaCreacion.Value
            };

            MessageBox.Show("Método de pago guardado correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
