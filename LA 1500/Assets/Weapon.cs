using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


    
        


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        transform.rotation = Quaternion.Euler(Vector3.forward * -45);
       
       


        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        }

    }

}

   
        
     

    
    
