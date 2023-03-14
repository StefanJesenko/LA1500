using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
   
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 2f;
 
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
      
        if(player.transform.position.x > 36)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Touch")
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            //enemy.SetActive(false);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
