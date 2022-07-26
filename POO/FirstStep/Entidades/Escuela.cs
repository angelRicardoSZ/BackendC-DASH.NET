namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value.ToUpper();}
        }
        public int AnnioCreacion {get;set;}

        public string Pais{get;set;} 
        public string Ciudad{get;set;}
        
        public Escuela(string nombre, int annio) => (Nombre, AnnioCreacion) = (nombre,annio);

    }
}