using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaIncial;
    [SerializeField] float curaIntroducidad, danhoHecho;
    float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaIncial;
        vidaActual = RecibirCura(curaIntroducidad);
        Debug.Log("Tu vida actual es " + vidaActual);
        RecibirDanho(danhoHecho);
    }

    // Update is called once per frame
    void Update()
    {

    }
    float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            vidaActual = -1;
        }
        else
        {
            vidaActual += cantidad;
        }

        return vidaActual;
    }
    float RecibirDanho(float danho)
    {


        return danho;
    }
}
