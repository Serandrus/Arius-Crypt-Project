using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour {
    //movimiento de la camara
    Vector2 mouseLook;
    //mejorar el movimiento
    Vector2 smoothV;
    //Sensiblilidad.
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;
	//Toma el movimiento ligado al cursor.
	void Start ()
    {
        //ligado al padre.
        character = this.transform.parent.gameObject;
	}
	
	void Update ()
    {
        //Rotacion de la camara.
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
