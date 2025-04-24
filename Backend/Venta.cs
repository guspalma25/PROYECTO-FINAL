public class Venta : EntidadBase
{
    public int ClienteId { get; set; }
    public DateTime FechaVenta { get; set; }
    public decimal Total { get; set; }
    public string MetodoPago { get; set; }
    public string Estado { get; set; }
    public decimal Descuento { get; set; }
    public string TipoVenta { get; set; }
    public int EmpleadoId { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["ClienteId"] = ClienteId,
            ["FechaVenta"] = FechaVenta,
            ["Total"] = Total,
            ["MetodoPago"] = MetodoPago,
            ["Estado"] = Estado,
            ["Descuento"] = Descuento,
            ["TipoVenta"] = TipoVenta,
            ["EmpleadoId"] = EmpleadoId
        };
    }
}
