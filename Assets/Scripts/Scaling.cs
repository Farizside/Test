using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;

    void Update()
    {
        transform.localScale = new Vector4(Mathf.PingPong(Time.time, (maxScale-minScale))+minScale, transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
