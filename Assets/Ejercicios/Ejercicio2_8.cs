using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    //float venenoTurno1 = 3.6f, venenoTurno2 = 7.2f, venenoTurno3 = 10.8f, venenoTurno4 = 14.4f,venenoTurno5 = 18f; dejo esto precalculado para ver que me cuadren los valores
    float vidaInicial = 120;
    float vidaActual;
    float venenoTurno1 , venenoTurno2 , venenoTurno3 , venenoTurno4 ,venenoTurno5 ;
    float porcentajeDa�o = 3;
    float acumulacionVeneno = 3;
    float porcentajeDa�oAumentado = 3;
    float valorTotal = 100;
    //
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pepe empieza la pelea con un total de " + vidaInicial + " puntos de vida, veamos como le va a Pepe.");
        vidaActual = vidaInicial;
        Debug.Log("A pepe le han envenenado, pobre pepe, este turno pepe pierde un 3% del total de su vida");
        venenoTurno1 = vidaInicial  * porcentajeDa�o / valorTotal;
        vidaActual -= venenoTurno1;
        Debug.Log("Vida total de Pepe ahora es " + vidaActual );

        Debug.Log("Ha pasado un turno, ahora pepe pierde un 6% del total de su vida");
        porcentajeDa�oAumentado = porcentajeDa�o + acumulacionVeneno;
        venenoTurno2 = vidaInicial * porcentajeDa�oAumentado / valorTotal;
        vidaActual -= venenoTurno2;
        Debug.Log("Vida total de Pepe ahora es " + vidaActual );     
        
        Debug.Log("Ha pasado otro turno, ahora pepe pierde un 9% del total de su vida, pepe esta jodido");
        porcentajeDa�oAumentado += acumulacionVeneno;
        venenoTurno3 = vidaInicial * porcentajeDa�oAumentado / valorTotal;
        vidaActual -= venenoTurno3;

        Debug.Log("Vida total de Pepe ahora es " + vidaActual );        

        Debug.Log("Ha pasado otro turno, ahora pepe pierde un 12% del total de su vida, pepe...pepe...");
        porcentajeDa�oAumentado += acumulacionVeneno;
        venenoTurno4 = vidaInicial * porcentajeDa�oAumentado / valorTotal;
        vidaActual -= venenoTurno4;

        Debug.Log("Vida total de Pepe ahora es " + vidaActual );   
        
        Debug.Log("Ha pasado otro turno, ahora pepe pierde un 15% del total de su vida, joer pepe, encuentra la cura macho.");
        porcentajeDa�oAumentado += acumulacionVeneno;
        venenoTurno5 = vidaInicial * porcentajeDa�oAumentado / valorTotal;
        vidaActual -= venenoTurno5;
        Debug.Log("Vida total de Pepe ahora es " + vidaActual ); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
