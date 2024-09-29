using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMinimo, danhoMaximo;
    [SerializeField] int CapacidadTotal;
    [SerializeField] bool automatica;
    [SerializeField] SistemaDeVida sistemaDeVida;
    int municionActual;
    // Start is called before the first frame update
    void Start()
    {
        municionActual = CapacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual -= 1;
            Debug.Log("0");

            sistemaDeVida.RecibirDanho(Random.Range(danhoMinimo, danhoMaximo));

        }
        else
        {
            
            Debug.Log("-1");
            Debug.Log("Reload");

        }
    }
    public void RecargarArma()
    {
        if (municionActual < CapacidadTotal)
        {
            municionActual = CapacidadTotal;
            Debug.Log("0");
            Debug.Log("Recargaste " + CapacidadTotal + " tu municion vuelve a ser " + municionActual);
        }
        else
        {
            Debug.Log("-1");
            Debug.Log("Arma ya cargada.");
        }
    }


}
