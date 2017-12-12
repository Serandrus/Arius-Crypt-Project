using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageFuego : MonoBehaviour {

    public Slider barraVida;

    //Si el jugador entra en contacto le resta vida
    void OnTriggerStay(Collider other)
    {
        barraVida.value -= 3;
    }
}
