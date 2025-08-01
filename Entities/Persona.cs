namespace Entities
{
    public abstract class Persona

    {
        public int IdPersona { get; set; }
        public string ApellidoNombre { get; set; }
        public string Mail { get; set; }
        public string Contrasenia { get; set; }

       
        public Persona(string apellidoNombre,string mail, string contrasenia, int idPersona)
        {
            IdPersona = idPersona;
            ApellidoNombre = apellidoNombre;
            Mail = mail;
            Contrasenia = contrasenia;
        }
    }
}
