using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript2 : MonoBehaviour
{
    public Transform weaponProjectilePoint;
    public GameObject projectilePrefab;
    public float timeLimit = 1f;
    public float timeRemaining;



    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if (timeLimit <= 0)
        {

            Shoot();
            timeLimit = 1f;
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, weaponProjectilePoint.position, weaponProjectilePoint.rotation);
    }
}
