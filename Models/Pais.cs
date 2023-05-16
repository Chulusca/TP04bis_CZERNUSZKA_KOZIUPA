using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04bis_CZERNUSZKA_KOZIUPA.Models;

public class Pais{
    
    private string nombre {get;set;}
    private string imgBandera {get;set;}
    private int poblacion {get;set;}
    private DateTime fechaIndependencia {get;set;}
    private string atractivosTuristicos {get;set;}

    public Pais(){

    }
    public Pais(string n, string imgB, int pob, DateTime fI, string aT){
        nombre = n;
        imgBandera = imgB;
        poblacion = pob;
        fechaIndependencia = fI;
        atractivosTuristicos = aT;
    } 

    public string ObtenerNombre(string nombre){
        return nombre;
    }
    public string ObtenerBandera(string imgBandera){
        return imgBandera;
    }
    public int ObtenerPoblacion(int poblacion){
        return poblacion;
    }
    public DateTime ObtenerFI(DateTime fechaIndependencia){
        return fechaIndependencia;
    }
    public string ObtenerAT(string atractivosTuristicos){
        return atractivosTuristicos;
    }
}
