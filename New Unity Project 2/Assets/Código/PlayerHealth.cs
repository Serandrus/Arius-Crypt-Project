using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    //Vida del jugador
    public int startHealth = 100;
    public Slider barraDeVida;
    //Se llama a la variable del puntaje
    Puntaje puntaje;
   
    void Update()
    {
        //si la vida llega a cero hacer:
        if (barraDeVida.value <= 0)
        {
            //recargar la escena
            SceneManager.LoadScene("Game");
            //Reiniciar los puntos;
            Puntaje.puntos = 0;
        }
    }
}
