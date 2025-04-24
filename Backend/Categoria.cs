public class Categoria : EntidadBase
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Activa { get; set; }
    public int ProductosEnCategoria { get; set; }
    public string CodigoCategoria { get; set; }
    public decimal ValorMinimo { get; set; }
    public decimal ValorMaximo { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Nombre"] = Nombre,
            ["Descripcion"] = Descripcion,
            ["FechaCreacion"] = FechaCreacion,
            ["Activa"] = Activa,
            ["ProductosEnCategoria"] = ProductosEnCategoria,
            ["CodigoCategoria"] = CodigoCategoria,
            ["ValorMinimo"] = ValorMinimo,
            ["ValorMaximo"] = ValorMaximo
        };
    }
}
