using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargadorPortal : MonoBehaviour
{
    //Cargar una escena.
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Game");
    }
}
