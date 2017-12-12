using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageLanza : MonoBehaviour {

    public Slider barraDeVida;
    //Si el jugador entra en contacto le resta vida
    public void OnTriggerEnter(Collider other)
    {
        barraDeVida.value -= 15;
    }
}
