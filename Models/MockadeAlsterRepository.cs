using System;

namespace uppfinnaren_1_0_seb_kvist.Models;

public class MockadeAlsterRepository : IAlsterRepository
{
    public IEnumerable<Alster> AllaAlster() //Mina hårdkodade alster för att simulera databas --> ska gå o byta ut mot faktiskt data
    {
        return new List<Alster>
        {
            new Alster { AlsterId = 1, Namn = "Träskor", Beskrivning = "Träskor målade röda", BildUrl = "/bilder/trasko.jpg"},
            new Alster { AlsterId = 2, Namn = "Träram", Beskrivning = "En blå träram", BildUrl = "/bilder/traram.jpg"},
            new Alster { AlsterId = 3, Namn = "Träbord", Beskrivning = "Ett gult träbord", BildUrl = "/bilder/trabord.jpg"},
            new Alster { AlsterId = 4, Namn = "Träbokhylla", Beskrivning = "En grön bokhylla", BildUrl = "/bilder/trabokhylla.jpg"}
        };
    } 

        public Alster? HittaAlsterMedId(int id)
    {
        return AllaAlster().FirstOrDefault(a => a.AlsterId == id);
    }
}

