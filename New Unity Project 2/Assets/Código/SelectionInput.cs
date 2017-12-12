using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Con este script se podrá pasearse por el menú sin la necesidad de mouse (teclas o mando).
public class SelectionInput : MonoBehaviour {

    //public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;
	
	void Update () {
	    if(Input.GetAxisRaw ("Vertical") != 0 && buttonSelected == false)
        {
            //eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }	
	}

    private void OnDisable()
    {
        buttonSelected = false;
    }
}
