using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public static int puntos = 0;
    public Text textoPuntos;
    public TablitaChingona tablitaChingona;
    public InputField nombreJugador;
    public Button botonDeAcaptar;

    public void PlayerName()
    {
        //toma los valores y argumentos del script de la leaderboard.
        tablitaChingona.VerificarPuntuacion(puntos, nombreJugador.text);
    }

    void Start ()
    {
        ActualizarMarcadorPuntos();
    }

    void ActualizarMarcadorPuntos()
    {
        //muestra el puntaje y lo va actualizando.
        textoPuntos.text = "Puntos: " + Puntaje.puntos;
    }
	//Los puntos se suman
    public void GanarPuntos()
    {
        Puntaje.puntos += 5;
        ActualizarMarcadorPuntos();
    }
}
