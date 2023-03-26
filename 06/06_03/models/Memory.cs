namespace models
{
    public class Memory
    {
        // attributen
        private int _waarde;
        private string _soort;
        private string _kleur;

        // properties
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }
        public string Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }
        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        // constructor
        public Memory(int waarde, string soort, string kleur)
        {
            this.Waarde = waarde;
            this.Soort = soort;
            this.Kleur = kleur;
        }

        // methodes
        public override string ToString()
        {
            return $"{this.Waarde}, {this.Soort}, {this.Kleur}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Memory memory)
            {
                return this.Waarde == memory.Waarde &&
                    this.Soort == memory.Soort &&
                    this.Kleur == memory.Kleur;
            }
            else
            {
                return false;
            }
        }
    }
}
