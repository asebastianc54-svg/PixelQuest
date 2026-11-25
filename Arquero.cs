namespace PixelQuest
{
    public class Arquero : Personaje
    {
        public int CantidadFlechas { get; set; }

        public Arquero(string nombre, int cantidadFlechas) : base(nombre)
        {
            CantidadFlechas = cantidadFlechas;
        }

        public override string Atacar()
        {
            return $"[{Nombre}] El arquero tensa su arco y dispara una ráfaga precisa ({CantidadFlechas} flechas disponibles).";
        }
    }
}
