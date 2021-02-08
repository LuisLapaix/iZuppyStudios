using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float Randomizer;
    public GameObject[] Car1;
    public GameObject[] Car2;
    public GameObject[] Car3;
    public GameObject[] Car4;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("GenerateUnoTres", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        print(Randomizer);
    }

    void GenerateUnoTres()
    {
        Instantiate(Car1[0], transform.position, Quaternion.identity);
        Instantiate(Car3[0], transform.position, Quaternion.identity);
        Instantiate(Car2[0], transform.position, Quaternion.identity);
        Instantiate(Car4[0], transform.position, Quaternion.identity);
    }
}


