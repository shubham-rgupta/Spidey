using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstraintController : MonoBehaviour
{
    Vector3 originalPos;
    void Start()
    {
        originalPos = transform.position;
    }

    
    void Update()
    {
        transform.position = originalPos;
    }
}
