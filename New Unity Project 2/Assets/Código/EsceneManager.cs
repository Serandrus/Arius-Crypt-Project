using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EsceneManager : MonoBehaviour {

	//Ejecutar la corutina que contiene el método.
	void Start ()
    {
        StartCoroutine("Countdown");
	}
	//hace que luego de 7 segundos cargue la escena destinada.
	private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("MainMenu");
    }
}
