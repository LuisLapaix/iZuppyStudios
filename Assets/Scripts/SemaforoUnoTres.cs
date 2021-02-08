using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoUnoTres : MonoBehaviour
{
    public GameObject semaforoUnoTres_Verde;
    public GameObject semaforoUnoTres_Amarillo;
    public GameObject semaforoUnoTres_Rojo;
    public bool Semaforo_UnoTres;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLight());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SemaforoUnoTresVerde() 
    {
        semaforoUnoTres_Verde.SetActive(true);
        semaforoUnoTres_Amarillo.SetActive(false);
        semaforoUnoTres_Rojo.SetActive(false);
        Semaforo_UnoTres = true;
    }

    void SemaforoUnoTresAmarillo()
    {
        semaforoUnoTres_Verde.SetActive(false);
        semaforoUnoTres_Amarillo.SetActive(true);
        semaforoUnoTres_Rojo.SetActive(false);
        Semaforo_UnoTres = true;
    }
    void SemaforoUnoTresRojo()
    {
        semaforoUnoTres_Verde.SetActive(false);
        semaforoUnoTres_Amarillo.SetActive(false);
        semaforoUnoTres_Rojo.SetActive(true);
        Semaforo_UnoTres = false;
    }

    IEnumerator TrafficLight() 
    {
        while (true) 
        {
            SemaforoUnoTresVerde();
            yield return new WaitForSeconds(4);
            SemaforoUnoTresAmarillo();
            yield return new WaitForSeconds(2);
            SemaforoUnoTresRojo();
            yield return new WaitForSeconds(8);

         
        }
    }

}
