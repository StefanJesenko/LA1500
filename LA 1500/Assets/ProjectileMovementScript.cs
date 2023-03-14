using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovementScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {

            GetComponent<CircleCollider2D>().enabled = false;
        }
    }
}