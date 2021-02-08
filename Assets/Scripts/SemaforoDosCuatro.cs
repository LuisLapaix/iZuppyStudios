using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoDosCuatro : MonoBehaviour
{
    public GameObject semaforoDosCuatro_Verde;
    public GameObject semaforoDosCuatro_Amarillo;
    public GameObject semaforoDosCuatro_Rojo;
    public bool Semaforo_DosCuatro;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLight());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SemaforoDosCuatroVerde()
    {
        semaforoDosCuatro_Verde.SetActive(true);
        semaforoDosCuatro_Amarillo.SetActive(false);
        semaforoDosCuatro_Rojo.SetActive(false);
        Semaforo_DosCuatro = true;
    }

    void SemaforoDosCuatroAmarillo()
    {
        semaforoDosCuatro_Verde.SetActive(false);
        semaforoDosCuatro_Amarillo.SetActive(true);
        semaforoDosCuatro_Rojo.SetActive(false);
        Semaforo_DosCuatro = true;
    }
    void SemaforoDosCuatroRojo()
    {
        semaforoDosCuatro_Verde.SetActive(false);
        semaforoDosCuatro_Amarillo.SetActive(false);
        semaforoDosCuatro_Rojo.SetActive(true);
        Semaforo_DosCuatro = false;
    }

    IEnumerator TrafficLight()
    {
        while (true)
        {
            SemaforoDosCuatroRojo();
            yield return new WaitForSeconds(8);
            SemaforoDosCuatroVerde();
            yield return new WaitForSeconds(4);
            SemaforoDosCuatroAmarillo();
            yield return new WaitForSeconds(2);


        }
    }
}
