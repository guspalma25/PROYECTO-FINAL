public class Usuario : EntidadBase
{
    public string NombreUsuario { get; set; }
    public string Contrasena { get; set; }
    public string Correo { get; set; }
    public string Rol { get; set; }
    public bool EstadoCuenta { get; set; }
    public DateTime FechaRegistro { get; set; }
    public DateTime FechaUltimoAcceso { get; set; }
    public string PreguntaSeguridad { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            ["Id"] = Id,
            ["NombreUsuario"] = NombreUsuario,
            ["Contrasena"] = Contrasena,
            ["Correo"] = Correo,
            ["Rol"] = Rol,
            ["EstadoCuenta"] = EstadoCuenta,
            ["FechaRegistro"] = FechaRegistro,
            ["FechaUltimoAcceso"] = FechaUltimoAcceso,
            ["PreguntaSeguridad"] = PreguntaSeguridad
        };
    }
}
