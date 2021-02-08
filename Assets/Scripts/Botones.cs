using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public void Tortuga()
    {
        Time.timeScale = 0.5f;
    }

    public void Liebre()
    {
        Time.timeScale = 3;
    }

    public void Avion()
    {
        Time.timeScale = 50;
    }

    public void Normal()
    {
        Time.timeScale = 1;
    }


}
