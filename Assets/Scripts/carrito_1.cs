using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrito_1 : MonoBehaviour
{
    public GameObject LightStatus;
    public bool AMET;
    Controller controller = new Controller();
    // Start is called before the first frame update
    void Start()
    {
        AMET = false;
        transform.position = new Vector2(-13, -0.85f);
        LightStatus = GameObject.Find("Semaforo1");
    }

    // Update is called once per frame
    void Update()
    {
        if (LightStatus.GetComponent<SemaforoUnoTres>().Semaforo_UnoTres || AMET) 
        {
            float direction = controller.car_speed * Time.deltaTime;
            transform.Translate(Vector3.right * direction);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);        
        }
        if (collision.tag == "AMET")
        {
            AMET = true;
        }
    }
}
