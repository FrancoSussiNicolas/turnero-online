namespace Entities
{
    public abstract class Persona

    {
        public int PersonaId { get; set; }
        public string ApellidoNombre { get; set; }
        public string Mail { get; set; }
        public string Contrasenia { get; set; }
        
        public Persona(string apellidoNombre,string mail, string contrasenia)
        {
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
        }
    }
}
