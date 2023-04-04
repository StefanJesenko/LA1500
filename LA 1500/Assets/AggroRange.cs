using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroRange : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    private float aggroRange;
    [SerializeField] private float speed = 2f;
    
    void Start()
    {
        aggroRange = enemy.transform.position.x;
    }

    void Update()
    {
        if (player.transform.position.x > aggroRange && player.transform.position.x < 69)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
