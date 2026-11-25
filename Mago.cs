namespace PixelQuest
{
    public class Mago : Personaje
    {
        public string ElementoMagico { get; set; } = string.Empty;

        public Mago(string nombre, string elementoMagico) : base(nombre)
        {
            ElementoMagico = elementoMagico;
        }

        public override string Atacar()
        {
            return $"[{Nombre}] El mago conjura una tormenta arcana de {ElementoMagico} sobre el enemigo.";
        }
    }
}
