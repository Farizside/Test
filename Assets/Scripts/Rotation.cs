using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f,0f,rotationSpeed);
    }
}
