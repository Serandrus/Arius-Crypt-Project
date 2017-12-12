using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TablitaChingona : MonoBehaviour {

    public Text[] puntajeMasAlto;
    int[] valoresDePuntajesAltos;
    string[] nombresDeLosPuntajes;

	void Start ()
    {
        //hacer que los valores sean del tamaño del array
        valoresDePuntajesAltos = new int[puntajeMasAlto.Length];
        nombresDeLosPuntajes = new string[puntajeMasAlto.Length];

        for (int x = 0; x < puntajeMasAlto.Length; x++)
        {
            //Obtiene la información de las variables
            valoresDePuntajesAltos[x] = PlayerPrefs.GetInt("valoresDePuntajesAltos" + x);
            nombresDeLosPuntajes[x] = PlayerPrefs.GetString("nombreDeLosPuntajes" + x);
        }
        //Ejecuta la función
        EscribirPuntuacion();
	}
	
    void GuardarPuntuacion()
    {
        for (int x = 0; x < puntajeMasAlto.Length; x++)
        {
            //Guarda los datos creados por el jugador.
            PlayerPrefs.SetInt("valoresDePuntajesAltos" + x, valoresDePuntajesAltos[x]);
            PlayerPrefs.SetString("nombresDeLosPuntajes" + x, nombresDeLosPuntajes[x]);
        }
    }

    //Esta parte es para ir actualizando el puntaje mayor
    public void VerificarPuntuacion(int _valor, string _nombreDeUsuario)
    {
        for(int x = 0; x < puntajeMasAlto.Length; x++)
        {
            if(_valor> valoresDePuntajesAltos[x])
            {
                for (int y = puntajeMasAlto.Length - 1; y > x; y--)
                {
                    valoresDePuntajesAltos[y] = valoresDePuntajesAltos[y - 1];
                    nombresDeLosPuntajes[y] = nombresDeLosPuntajes[y - 1];
                }

                valoresDePuntajesAltos[x] = _valor;
                nombresDeLosPuntajes[x] = _nombreDeUsuario;

                EscribirPuntuacion();
                GuardarPuntuacion();
                break;
            }
        }
    }

	void EscribirPuntuacion ()
    {
        //Con esto se muestran los nombres y puntos dentro del juego.
		for(int x = 0; x < puntajeMasAlto.Length; x++)
        {
            puntajeMasAlto[x].text = nombresDeLosPuntajes[x] + " -------------------- " + valoresDePuntajesAltos[x].ToString();
        }
	}
}
