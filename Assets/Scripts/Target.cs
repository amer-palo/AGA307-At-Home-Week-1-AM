using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirection{forward, backward}
public class Target : MonoBehaviour
{
    //public GameObject smallTarget;
    //public GameObject mediumTarget;
    //public GameObject largeTarget;
    public Size size;
    public MoveDirection direction;
    public Vector3 newPos;
    public bool isMoving = false;
    public float time;
    private float maxTime = 10;
    public Vector3 moveDirection;
    public bool isSpawned = false;

    void Start()
    {
       SetupSize();
       

        maxTime = 10;

    }


    void Update()
    {
        
        if (isSpawned)
        { 
        
            if (!isMoving)
            {
                ChangeMoveDirection();
            
                time = 0;
            
            }
            time += Time.deltaTime;

        }

    }
    void SetupSize()
    {
        switch (size)
        {
            case Size.Small:
                transform.localScale = Vector3.one * 0.5f;
                break;

            case Size.Medium:
                transform.localScale = Vector3.one * 1f;
                break;

            case Size.Large:
                transform.localScale = Vector3.one * 2f;
                break;
        }
    }

    void ChangeMoveDirection()
    {
        switch (direction)
        {
            case MoveDirection.forward:
                newPos = -transform.forward * 4;
                moveDirection = -transform.forward * 0.5f;
                direction = MoveDirection.backward;
                break;

            case MoveDirection.backward:
                newPos = transform.forward * 4;
                moveDirection = transform.forward * 0.5f;
                direction = MoveDirection.forward;
                break;
        }
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {

        isMoving = true;
        while (time < maxTime)
        {
            yield return new WaitForSeconds(0.25f);
            
            transform.Translate(moveDirection);
        }
        isMoving = false;


    }
}