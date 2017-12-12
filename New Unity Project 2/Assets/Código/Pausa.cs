using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {
    //indicar que la pausa esté o no activa
    bool active;
    Canvas canvas;
    public GameObject pausar;

	// Use this for initialization
	void Start ()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("escape"))
        {
            active = !active;
            canvas.enabled = active;
            //si la pausa está desactivada la velocidad del juego es 0 sino es 1.
            Time.timeScale = (active) ? 0 : 1f;
            //Toma el componente que indica la rotación de la camara.
            pausar.GetComponent<CamMouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(Time.timeScale == 1f)
        {
            pausar.GetComponent<CamMouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
	}
}
