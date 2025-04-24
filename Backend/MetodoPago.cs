public class MetodoPago : EntidadBase
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool Activo { get; set; }
    public decimal Comision { get; set; }
    public string TipoPago { get; set; }
    public string Codigo { get; set; }
    public string Moneda { get; set; }
    public DateTime FechaCreacion { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Descripcion"] = Descripcion,
            ["Activo"] = Activo,
            ["Comision"] = Comision,
            ["TipoPago"] = TipoPago,
            ["Codigo"] = Codigo,
            ["Moneda"] = Moneda,
            ["FechaCreacion"] = FechaCreacion
        };
    }
}
