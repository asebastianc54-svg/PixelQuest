namespace PixelQuest
{
    public class Personaje
    {
        private string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del personaje no puede estar vacío.");
                }
                nombre = value.Trim();
            }
        }

        public Personaje(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Atacar()
        {
            return $"[{Nombre}] Realiza un ataque básico.";
        }
    }
}
