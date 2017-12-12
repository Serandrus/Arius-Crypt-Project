using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargadorLeaderBoard : MonoBehaviour
{
    public GameObject canvas;
    //Cuando el jugador entre en contacto con el objeto
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            //activa el canvas con la tabla.
            canvas.gameObject.SetActive(true);
            //quita el lock al cursor.
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void Start()
    {
        //Hace que el canvas siempre esté desactivado.
        canvas.gameObject.SetActive(false);
    }

}
