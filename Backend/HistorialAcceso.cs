public class HistorialAcceso : EntidadBase
{
    public int UsuarioId { get; set; }
    public DateTime FechaAcceso { get; set; }
    public string IP { get; set; }
    public string Dispositivo { get; set; }
    public string Ubicacion { get; set; }
    public string Accion { get; set; }
    public string Resultado { get; set; }
    public string Descripcion { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["UsuarioId"] = UsuarioId,
            ["FechaAcceso"] = FechaAcceso,
            ["IP"] = IP,
            ["Dispositivo"] = Dispositivo,
            ["Ubicacion"] = Ubicacion,
            ["Accion"] = Accion,
            ["Resultado"] = Resultado,
            ["Descripcion"] = Descripcion
        };
    }
}
