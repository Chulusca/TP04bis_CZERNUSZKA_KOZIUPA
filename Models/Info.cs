namespace TP04bis_CZERNUSZKA_KOZIUPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Info{
    
    private static List<Pais> listaPaises {get;set;} = new List<Pais>();
    private static void InicializarLista(){
        Pais Vanuatu = new Pais("Vanuatu", "", 300000, new DateTime(1930,03,12) , "Esqui artificial");
        Pais España = new Pais("España" ,"" ,47000000, new DateTime(1808,2,5) , "Playas y Monumentos historicos");
        Pais Argentina = new Pais("Argentina" ,"" ,46000000, new DateTime(1816,7,9) , "Patagonia"); 
        Pais Bolivia = new Pais("Bolivia" ,"" ,12000000, new DateTime(1818, 5, 12) , "Salar de Uyuni");
        Pais Brasil = new Pais("Brasil" ,"" ,215000000, new DateTime(1822,9,7) , "Playas");

        listaPaises.Add(Vanuatu);
        listaPaises.Add(España);
        listaPaises.Add(Argentina);
        listaPaises.Add(Bolivia);
        listaPaises.Add(Brasil);
    } 
}