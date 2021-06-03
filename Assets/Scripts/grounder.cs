using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounder : MonoBehaviour
{
    int layermask;
    void Start()
    {
        layermask = LayerMask.GetMask("Ground");
    }

    
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position+ new Vector3(0f,0.75f,0f),-transform.up, out hit,Mathf.Infinity, layermask))
        {
            transform.position = hit.point + new Vector3(0f, 0.75f, 0f);
        }
    }
}
