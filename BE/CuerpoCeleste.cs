namespace BE
{
    public class CuerpoCeleste
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Tipo tipo;
        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

