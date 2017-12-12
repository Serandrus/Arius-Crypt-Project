using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dañito : MonoBehaviour {

    public Slider barritaDeVida;
    //Si el jugador entra en contacto le resta vida
    public void OnTriggerEnter(Collider other)
    {
        barritaDeVida.value -= 45;
    }
}
