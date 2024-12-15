using System;

namespace uppfinnaren_1_0_seb_kvist.Models;
public interface IAlsterRepository
{
    IEnumerable<Alster> AllaAlster();

    Alster? HittaAlsterMedId(int id);
    
}
