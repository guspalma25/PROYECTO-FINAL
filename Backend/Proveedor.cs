public class Proveedor : EntidadBase
{
    public string Nombre { get; set; }
    public string Contacto { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Pais { get; set; }
    public string Ciudad { get; set; }
    public string TipoProveedor { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Contacto"] = Contacto,
            ["Correo"] = Correo,
            ["Telefono"] = Telefono,
            ["Direccion"] = Direccion,
            ["Pais"] = Pais,
            ["Ciudad"] = Ciudad,
            ["TipoProveedor"] = TipoProveedor
        };
    }
}
