namespace logica
{
    public class Persona:EventArgs
    {
        public string Nombre { get; set; }
        public EventHandler<ActualizacionEventArgs> NombreModificado;
        public string ModificarNombre(string NombreActual, string NombreNuevo)
        {
            NombreActual = NombreNuevo;
            if (this.NombreModificado != null)
                this.NombreModificado(this, new ActualizacionEventArgs() { NombreNuevo = NombreNuevo });
            return NombreNuevo;
        }
}
}
