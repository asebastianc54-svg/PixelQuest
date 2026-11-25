using PixelQuest;

List<Personaje> equipo = new List<Personaje>
{
    new Guerrero("Arturo", 85),
    new Mago("Merlín", "Fuego"),
    new Arquero("Légolas", 24),
    new Personaje("Aldeano")
};

foreach (Personaje personaje in equipo)
{
    string resultadoTurno = personaje.Atacar();
    Console.WriteLine(resultadoTurno);
}
