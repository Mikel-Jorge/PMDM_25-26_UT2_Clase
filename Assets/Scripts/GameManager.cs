using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int monedas;
    public int Monedas { get { return monedas; } }

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
    }

    public void SumarMonedas()
    {
        monedas++;
        Debug.Log("Monedas: " + monedas);
    }
}
