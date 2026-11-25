namespace PixelQuest
{
    public class Guerrero : Personaje
    {
        public int Fuerza { get; set; }

        public Guerrero(string nombre, int fuerza) : base(nombre)
        {
            Fuerza = fuerza;
        }

        public override string Atacar()
        {
            return $"[{Nombre}] El guerrero blande su espada pesada causando {Fuerza} puntos de daño físico.";
        }
    }
}
