public class Cliente : EntidadBase
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }
    public DateTime FechaRegistro { get; set; }
    public bool Estado { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Correo"] = Correo,
            ["Telefono"] = Telefono,
            ["Direccion"] = Direccion,
            ["Edad"] = Edad,
            ["Genero"] = Genero,
            ["FechaRegistro"] = FechaRegistro,
            ["Estado"] = Estado
        };
    }
}
