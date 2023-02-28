using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Live : MonoBehaviour
{
    bool dead = false;
   // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -8.36f && !dead)
        {
            Die();
        }
    }
    void Die()
    {
        Invoke(nameof(RelodeLevel), 0.1f);
        dead = true;
    }
    void RelodeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
