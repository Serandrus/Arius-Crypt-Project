using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageDos : MonoBehaviour {

    public Slider barraSalud;

    //Si el jugador entra en contacto le resta vida
    void OnTriggerEnter(Collider other)
    {
        barraSalud.value -= 35;
    }
}
