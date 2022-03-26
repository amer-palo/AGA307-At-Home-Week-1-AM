using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void Start()
    {
        
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
            TargetManager.instance.DeleteAndDestroy(collision.gameObject);
        }

        else if(collision.gameObject.CompareTag("StaticTarget"))
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Destroy(collision.gameObject);
  

        }

        Destroy(gameObject);
    }

   

    
}
