using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {

    public Slider saludBar;
    //Si el jugador entra en contacto le resta vida
    public void OnTriggerStay(Collider other)
    {
        saludBar.value -= 1;
    }
}
