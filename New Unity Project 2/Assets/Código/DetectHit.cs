using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

    public Slider healthBar;
    //Si el jugador entra en contacto le resta vida
    void OnTriggerEnter(Collider other)
    {
        healthBar.value -= 20;
    }
}
