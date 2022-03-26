using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Size {Small, Medium, Large};

public class TargetManager : Singleton<TargetManager>
{
    public List<GameObject> listofTargets = new List<GameObject>();
    void Start()
    {
        
    }

    public void AddToList(GameObject _target)
    {
        listofTargets.Add(_target);
    }

    public void DeleteAndDestroy(GameObject _target)
    {
        GameObject objToDelete = null;

        for(int i = listofTargets.Count - 1; i >= 0; i--)
        {
            GameObject tempObject = listofTargets[i];

            if (_target == tempObject)

            {
                GameManager.instance.AddScore(1);
                objToDelete = _target;

                listofTargets.RemoveAt(i);
                break;
            }
        }

        Destroy(objToDelete);
    }
    void Update()
    {
        
    }
}
