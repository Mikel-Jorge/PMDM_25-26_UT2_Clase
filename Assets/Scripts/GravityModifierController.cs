using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityModifierController : MonoBehaviour
{
    public float modifier = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player") {
            Physics2D.gravity = Physics2D.gravity * modifier;
        }
    }
}
