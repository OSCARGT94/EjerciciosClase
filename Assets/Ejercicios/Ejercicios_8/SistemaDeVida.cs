using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaIncial;
    [SerializeField] float curaIntroducidad, danhoHecho;
    float vidaActual;

    public float CuraIntroducidad { get => curaIntroducidad; set => curaIntroducidad = value; }

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaIncial;
        Debug.Log("Tu vida actual es " + vidaActual);
        //vidaActual = RecibirCura(curaIntroducidad);
        //Debug.Log("Tu vida actual sumando poti es " + vidaActual);
        //vidaActual = RecibirDanho(danhoHecho);
        //Debug.Log("Tu vida actual restando daño es " + vidaActual);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            Debug.Log("-1");
            Debug.Log("Tu vida actual es " + vidaActual);
        }
        else
        {
            vidaActual += cantidad;
            Debug.Log("Tu vida actual es " + vidaActual);
        }

        return vidaActual;
    }
    public void RecibirDanho(float danho)
    {
        if (vidaActual > 0)
        {
            Debug.Log("0");

            vidaActual -= danho;
            if (vidaActual <= 0)
            {
                vidaActual = 0;
            }
            Debug.Log("Tu vida actual es " + vidaActual);
        }
        else
        {
            Debug.Log("-1");
        }

        //return vidaActual;
    }

}