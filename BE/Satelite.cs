namespace BE
{
    public class Satelite
    {
        private CuerpoCeleste planeta;
        public CuerpoCeleste Planeta
        {
            get { return planeta; }
            set { planeta = value; }
        }

        private CuerpoCeleste cuerpoSatelite;
        public CuerpoCeleste CuerpoSatelite
        {
            get { return cuerpoSatelite; }
            set { cuerpoSatelite = value; }
        }
    }
}

