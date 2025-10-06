using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMonedasController : MonoBehaviour
{

    public GameObject monedaPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 posicion = new Vector3(Random.Range(-57f, -36f), Random.Range(-2.5f, 6.6f), 0);
            Instantiate(monedaPrefab, posicion, Quaternion.identity);
        }
    }
}
