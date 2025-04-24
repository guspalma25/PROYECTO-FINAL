using System;
using System.Windows.Forms;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

    
    private void btnVideojuegos_Click(object sender, EventArgs e)
    {
        FormVideojuego formVideojuego = new FormVideojuego();
        formVideojuego.Show(); 
    }

    
    private void btnClientes_Click(object sender, EventArgs e)
    {
        FormCliente formCliente = new FormCliente();
        formCliente.Show(); 
    }

   
    private void btnVentas_Click(object sender, EventArgs e)
    {
        FormVenta formVenta = new FormVenta();
        formVenta.Show(); 
    }

    
    private void btnFacturas_Click(object sender, EventArgs e)
    {
        FormFactura formFactura = new FormFactura();
        formFactura.Show(); 
    }

    
    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close(); 
    }
}
