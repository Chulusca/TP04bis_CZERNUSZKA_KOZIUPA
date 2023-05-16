namespace TP04bis_CZERNUSZKA_KOZIUPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Info{
    
    private static List<Pais> listaPaises {get;set;} = new List<Pais>();
    private static void InicializarLista(){
        Pais Vanuatu = new Pais("Vanuatu", "vanuatu.png", 300000, new DateTime(1930,03,12) , "Esqui artificial");
        Pais España = new Pais("España" ,"españa.png" ,47000000, new DateTime(1808,2,5) , "Playas y Monumentos historicos");
        Pais Argentina = new Pais("Argentina" ,"argentina.png" ,46000000, new DateTime(1816,7,9) , "Patagonia"); 
        Pais Bolivia = new Pais("Bolivia" ,"bolivia.png" ,12000000, new DateTime(1818, 5, 12) , "Salar de Uyuni");
        Pais Brasil = new Pais("Brasil" ,"brasil.png" ,215000000, new DateTime(1822,9,7) , "Playas");

        listaPaises.Add(Vanuatu);
        listaPaises.Add(España);
        listaPaises.Add(Argentina);
        listaPaises.Add(Bolivia);
        listaPaises.Add(Brasil);
    } 
    public static List<Pais> ListarPais(){
        if (listaPaises.Count < 0) InicializarLista();
        return listaPaises;
    }
    public static Pais DetallePais(string nombre){
        int i = 0;
        bool fueEncontrado = false;
        int posPais = -1;
        if(listaPaises.Count > 0){
            while(!fueEncontrado && i < listaPaises.Count){
                if(nombre == listaPaises[i].ObtenerNombre()){
                    fueEncontrado = true;
                    posPais = i;
                }
            }
            if(fueEncontrado) return listaPaises[posPais];
            else return null;
        }else return null;
    }
}
