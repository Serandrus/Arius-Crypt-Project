using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimiento : MonoBehaviour {

    public float speed = 10.0F;
    public float jumpPower = 6.5f;
    private Rigidbody rb;
    bool suelo;

    private bool jump;


    void Start()
    {
        //apagar el cursor.
        Cursor.lockState = CursorLockMode.Locked;
        //traer el componente del rigibody para usarlo.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        //Define el tiempo que ha pasado desde el ultimo update para mantener un movimiento constante.
        translation *= Time.deltaTime; //movimienton en Z
        straffe *= Time.deltaTime;//Moviniento en X
      
        transform.Translate(straffe, 0, translation);

        
        
        //Volver a activarlo (cursor)
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }

    

    void FixedUpdate()
    {
        //Agregar la acción de saltar
        if (Input.GetKeyDown("space") && suelo == true)
        {
            rb.AddForce(0, jumpPower, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Piso"))
        {
            suelo = true;
            //Debug.Log("Tocando el piso");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        suelo = false;
        //Debug.Log("Fuera del piso");

    }
}
