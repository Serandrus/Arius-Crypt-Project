using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarVida : MonoBehaviour {

    public Slider barritaV;
    //Si el jugador entra en contacto le suma vida
    private void OnTriggerStay(Collider other)
    {
        barritaV.value += 5;
    }
}
