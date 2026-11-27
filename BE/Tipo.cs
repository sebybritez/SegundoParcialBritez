namespace BE
{
    public class Tipo
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

        public override string ToString()
        {
            return nombre;
        }
    }
}

