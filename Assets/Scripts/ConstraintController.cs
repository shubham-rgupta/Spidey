using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstraintController : MonoBehaviour
{
    Vector3 originalPos;
    public GameObject moveCube;
    float legMoveSpeed= 7f;
    public ConstraintController oppLegs;
    private bool isMoving = false;
    private bool moving = false;
    public float moveDistance = 0.7f;
    public float stopDistance = 0.5f;

    void Start()
    {
        originalPos = transform.position;
    }

    
    void Update()
    {
        float distanceToMoveCube = Vector3.Distance(transform.position, moveCube.transform.position);
        if((distanceToMoveCube >= 0.7f && !oppLegs.isItMoving()) || moving)
        {
            moving = true;
            transform.position = Vector3.Lerp(transform.position, moveCube.transform.position + new Vector3(0f, 0.3f, 0f), Time.deltaTime * legMoveSpeed);
            originalPos = transform.position;
            isMoving = true;
            if (distanceToMoveCube < stopDistance)
            {
                moving = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPos + new Vector3(0f,-0.3f, 0f), Time.deltaTime * legMoveSpeed*3);
            isMoving = false;
        }
    }

    public bool isItMoving()
    {
        return isMoving;
    }
}
