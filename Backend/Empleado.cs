public class Empleado : EntidadBase
{
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public decimal Salario { get; set; }
    public DateTime FechaContratacion { get; set; }
    public string Estado { get; set; }
    public string Departamento { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Cargo"] = Cargo,
            ["Correo"] = Correo,
            ["Telefono"] = Telefono,
            ["Salario"] = Salario,
            ["FechaContratacion"] = FechaContratacion,
            ["Estado"] = Estado,
            ["Departamento"] = Departamento
        };
    }
}
