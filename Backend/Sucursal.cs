public class Sucursal : EntidadBase
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string Pais { get; set; }
    public string Telefono { get; set; }
    public bool Activa { get; set; }
    public DateTime FechaApertura { get; set; }
    public int NumeroEmpleados { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Direccion"] = Direccion,
            ["Ciudad"] = Ciudad,
            ["Pais"] = Pais,
            ["Telefono"] = Telefono,
            ["Activa"] = Activa,
            ["FechaApertura"] = FechaApertura,
            ["NumeroEmpleados"] = NumeroEmpleados
        };
    }
}
