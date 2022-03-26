using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject myPrefab = null;
    void Start()
    {
        
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

           GameObject spawnedObject =  Instantiate(myPrefab, transform);

            spawnedObject.transform.localPosition = Vector3.zero;

            GetComponent<Target>().isSpawned = true;

            TargetManager.instance.AddToList(gameObject);
        }

    }
}
