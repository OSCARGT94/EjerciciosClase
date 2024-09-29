using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMinimo, danhoMaximo;
    [SerializeField] int CapacidadTotal;
    [SerializeField] bool automatica;
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

        }
        else
        {
            municionActual = 0;
        }
    }
    public void RecargarArma()
    {
        if (municionActual < CapacidadTotal)
        {
            municionActual = CapacidadTotal;
            Debug.Log("0");
        }
        else
        {
            Debug.Log("1");
        }
    }


}
