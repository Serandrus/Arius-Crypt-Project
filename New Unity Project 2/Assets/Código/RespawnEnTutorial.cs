using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnEnTutorial : MonoBehaviour {

    public int vidaInicial = 100;
    public Slider barraSalud;

    //Te devuelve a la posición inicial cuando la barra de vida llega a cero.
    void Update()
    {
        if (barraSalud.value <= 0)
        {
            gameObject.transform.position = new Vector3(-192, 2.05f, 31.6f);
            barraSalud.value = vidaInicial;
        }
    }
}
