using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex (string sceneIndex)
    {
        //Carga la escena al darle click al botón designado.
        SceneManager.LoadScene(sceneIndex);
    }
}
