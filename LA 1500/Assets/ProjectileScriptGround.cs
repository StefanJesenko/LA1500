using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScriptGround : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 2f;
    public Transform weaponProjectilePoint;
    [SerializeField] private float aggroRange;
    public GameObject projectilePrefab;
    public float timeLimit = 1f;
    public float timeRemaining;
    

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > aggroRange)
        {
           
            timeLimit -= Time.deltaTime;

            if (timeLimit <= 0)
            {

                Shoot();
                timeLimit = 1f;
            }
        }
    }
    void Shoot()
    {
        Instantiate(projectilePrefab, weaponProjectilePoint.position, weaponProjectilePoint.rotation);
    }
}
