public class DetalleVenta : EntidadBase
{
    public int VentaId { get; set; }
    public int VideojuegoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Descuento { get; set; }
    public decimal Total { get; set; }
    public DateTime Fecha { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["VentaId"] = VentaId,
            ["VideojuegoId"] = VideojuegoId,
            ["Cantidad"] = Cantidad,
            ["PrecioUnitario"] = PrecioUnitario,
            ["Subtotal"] = Subtotal,
            ["Descuento"] = Descuento,
            ["Total"] = Total,
            ["Fecha"] = Fecha
        };
    }
}
