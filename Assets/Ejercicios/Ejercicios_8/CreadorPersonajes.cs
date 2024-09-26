using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField]Personaje link;
    // Start is called before the first frame update
    void Start()
    {
        link.Vida = 100;
        //Debug.Log(link.Vida);


        link.mover(1,2,3);
    }

}
