using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour {

    public Puntaje puntaje;

    private void OnTriggerEnter(Collider other)
    {
        //Al tocar el objeto con el tag de moneda
        if(other.tag == "moneda")
        {
            //destruye el objeto
            Destroy(other.gameObject);
            //aumenta el puntaje con la cantidad establecida en el script.
            puntaje.GanarPuntos();
        }
    }
}
