using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity = 5f;
    public float jumpForce = 100f;
    public float jumpVelocity = 10f;
    public Collider2D feetCollider;
    public LayerMask groundLayer;
    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {}

    void FixedUpdate()
    {
        // Movimiento horizontal
        float movHorizontal = Input.GetAxis("Horizontal");
        gestionarGiro(movHorizontal);
        gestionarMovimientoHorizontal(movHorizontal);
        gestionarSalto();
    }

    void gestionarSalto()
    {
        if (feetCollider.IsTouchingLayers(groundLayer)
            && Input.GetKey(KeyCode.Space))
            //rb.AddForce(Vector2.up * jumpForce);
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
    }

    void gestionarMovimientoHorizontal(float inputMovimiento)
    {
        rb.velocity = new Vector2(inputMovimiento * velocity, rb.velocity.y);
        animator.SetFloat("inputMovimiento", inputMovimiento);
        
    }

    void gestionarGiro(float inputMovimiento)
    {
        if (inputMovimiento > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (inputMovimiento < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Aligerar")
        {
            rb.gravityScale = rb.gravityScale * 0.5f;
        }
    }
}








