using System;

namespace uppfinnaren_1_0_seb_kvist.Models;
public interface IAlsterRepository
{
    IEnumerable<Alster> AllaAlster {get;} //returnerar alla alster
    Alster? HämtaAlsterMedId(int alsterId); //För att hämta en specifik alster
}
