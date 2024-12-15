using System;
using Microsoft.AspNetCore.SignalR;

namespace uppfinnaren_1_0_seb_kvist.Models;

public class Alster
{
    public int AlsterId { get; set;}  //För att ge alster ett ID
    public string Namn {get; set;} = string.Empty; //Namnet på alstret
    public string Beskrivning {get; set;} = string.Empty; //Beskrivning på alstret
    public string BildUrl {get; set;} = string.Empty; //Visar en bild på alstret. 


}
