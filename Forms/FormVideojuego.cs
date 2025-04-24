using System;
using System.Windows.Forms;

public partial class FormVideojuego : Form
{
    public FormVideojuego()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Videojuego videojuego = new Videojuego
            {
                Id = int.Parse(txtId.Text),
                Titulo = txtTitulo.Text,
                Genero = txtGenero.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                Clasificacion = txtClasificacion.Text,
                Plataforma = txtPlataforma.Text,
                FechaLanzamiento = dtpFechaLanzamiento.Value,
                Descripcion = txtDescripcion.Text
            };

            MessageBox.Show("Videojuego guardado correctamente.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
        }
    }
}
