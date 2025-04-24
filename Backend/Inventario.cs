public class Inventario : EntidadBase
{
    public int VideojuegoId { get; set; }
    public int CantidadDisponible { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }
    public decimal PrecioUnitario { get; set; }
    public string Estado { get; set; }
    public string Ubicacion { get; set; }
    public int SucursalId { get; set; }
    public string Observaciones { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["VideojuegoId"] = VideojuegoId,
            ["CantidadDisponible"] = CantidadDisponible,
            ["FechaUltimaActualizacion"] = FechaUltimaActualizacion,
            ["PrecioUnitario"] = PrecioUnitario,
            ["Estado"] = Estado,
            ["Ubicacion"] = Ubicacion,
            ["SucursalId"] = SucursalId,
            ["Observaciones"] = Observaciones
        };
    }
}
