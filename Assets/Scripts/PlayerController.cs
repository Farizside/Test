using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform startPos, endPos;
    [SerializeField] private int speed;
    [SerializeField] private GameObject ballPrefabs;
    private Vector2 _targetPos;

    private void Start()
    {
        _targetPos = endPos.position;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, startPos.position) < 0.1f)
        {
            _targetPos = endPos.position;
        }
        if (Vector2.Distance(transform.position, endPos.position) < 0.1f)
        {
            _targetPos = startPos.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, _targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefabs, transform.position, quaternion.identity);
        }
    }
}
