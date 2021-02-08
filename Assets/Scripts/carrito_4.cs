using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrito_4 : MonoBehaviour
{
    public GameObject LightStatus;
    public bool AMET;
    Controller controller = new Controller();
    // Start is called before the first frame update
    void Start()
    {
        AMET = false;
        transform.position = new Vector2(-1, 12.3f);
        transform.Rotate(0, 0, 180);
        LightStatus = GameObject.Find("Semaforo4");
    }

    // Update is called once per frame
    void Update()
    {
        if (LightStatus.GetComponent<SemaforoDosCuatro>().Semaforo_DosCuatro || AMET)
        {
            float direction = controller.car_speed * Time.deltaTime;
            transform.Translate(Vector3.up * direction);
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
