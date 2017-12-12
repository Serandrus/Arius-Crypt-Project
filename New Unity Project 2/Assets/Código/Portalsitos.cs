using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portalsitos : MonoBehaviour {

    //Linkear los portales por codigo
    public int code;
    //Les pone un tiempo antes de activarse nuevamente
    float tiempoDesabilitado = 0;

    void Update()
    {
        if (tiempoDesabilitado > 0)
            tiempoDesabilitado -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider)
    {
        //cuando el jugador entre en contacto con el portal y su tiempo desabilitado es menor o igual a cero
        if (collider.gameObject.name == "player" && tiempoDesabilitado <= 0)
        {
            //Busca los objetos de tipo portal
            foreach(Portalsitos tp in FindObjectsOfType<Portalsitos>())
            {
                //realiza la funcion de mandar al jugador a la posición designada
                if(tp.code==code && tp != this)
                {
                    //establece el tiempo de desactivasión en 2 segundos
                    tp.tiempoDesabilitado = 2;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;
                }
            }
        }
    }
}
