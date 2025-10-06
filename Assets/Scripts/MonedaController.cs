using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaController : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // TODO lógica de recolectar monedas
            gameManager.SumarMonedas();
            Destroy(gameObject);
        }
    }
}
