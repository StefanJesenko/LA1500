using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Transform weaponProjectilePoint;
    public GameObject projectilePrefab;
    public float timeLimit = 1f;
    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if(timeLimit <= 0 )
        {
            Debug.Log("Time is up");
            Shoot();
            timeLimit = 1f;
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, weaponProjectilePoint.position, weaponProjectilePoint.rotation);
    }
}
