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
        Debug.Log("Tu vida actual sumando poti es " + vidaActual);
        vidaActual = RecibirDanho(danhoHecho);
        Debug.Log("Tu vida actual restando daño es " + vidaActual);
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
        if (vidaActual < 0)
        {
            vidaActual = -1;
        }
        else
        {
            vidaActual -= danho;
            if (vidaActual <= 0)
            {
                vidaActual = 0;
            }
        }

        return vidaActual;
    }
}
