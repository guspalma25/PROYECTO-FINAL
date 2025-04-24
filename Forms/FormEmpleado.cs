using System;
using System.Windows.Forms;

public partial class FormEmpleado : Form
{
    public FormEmpleado()
    {
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Empleado empleado = new Empleado
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Salario = decimal.Parse(txtSalario.Text),
                FechaContratacion = dtpFechaContratacion.Value,
                Estado = txtEstado.Text,
                Departamento = txtDepartamento.Text
            };

            MessageBox.Show("Empleado guardado:\n\n" +
                            $"Nombre: {empleado.Nombre}\n" +
                            $"Cargo: {empleado.Cargo}\n" +
                            $"Salario: {empleado.Salario:C}");

            
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
