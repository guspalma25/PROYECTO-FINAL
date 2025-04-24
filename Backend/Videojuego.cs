public class Videojuego : EntidadBase
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Clasificacion { get; set; }
    public string Plataforma { get; set; }
    public DateTime FechaLanzamiento { get; set; }
    public string Descripcion { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["Titulo"] = Titulo,
            ["Genero"] = Genero,
            ["Precio"] = Precio,
            ["Stock"] = Stock,
            ["Clasificacion"] = Clasificacion,
            ["Plataforma"] = Plataforma,
            ["FechaLanzamiento"] = FechaLanzamiento,
            ["Descripcion"] = Descripcion
        };
    }
}
