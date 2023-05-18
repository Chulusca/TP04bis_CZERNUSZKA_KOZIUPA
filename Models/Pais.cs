using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04bis_CZERNUSZKA_KOZIUPA.Models;

public class Pais{
    
    public string nombre {get;private set;}
    public string imgBandera {get;private set;}
    public int poblacion {get;private set;}
    public DateTime fechaIndependencia {get;private set;}
    public string atractivosTuristicos {get;private set;}

    public Pais(){

    }
    public Pais(string n, string imgB, int pob, DateTime fI, string aT){
        nombre = n;
        imgBandera = imgB;
        poblacion = pob;
        fechaIndependencia = fI;
        atractivosTuristicos = aT;
    } 
}
