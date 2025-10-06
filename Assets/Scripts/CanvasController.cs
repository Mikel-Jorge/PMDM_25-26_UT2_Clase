using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI monedas;

    void Update()
    {
        monedas.text = gameManager.Monedas.ToString();
    }
}
