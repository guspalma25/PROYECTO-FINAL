using System;
using System.Windows.Forms;

public partial class FormCategoria : Form
{
    public FormCategoria()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Categoria categoria = new Categoria
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaCreacion = dtpFechaCreacion.Value,
                Activa = chkActiva.Checked,
                ProductosEnCategoria = int.Parse(txtProductos.Text),
                CodigoCategoria = txtCodigo.Text,
                ValorMinimo = decimal.Parse(txtValorMinimo.Text),
                ValorMaximo = decimal.Parse(txtValorMaximo.Text)
            };

            MessageBox.Show("Categor�a guardada:\n\n" +
                            $"Nombre: {categoria.Nombre}\n" +
                            $"C�digo: {categoria.CodigoCategoria}\n" +
                            $"Activa: {(categoria.Activa ? "S�" : "No")}");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
