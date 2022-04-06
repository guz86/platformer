using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private float _direction;
    [SerializeField] private float _speed;
    public void SetDirection(float direction)
    {
        _direction = direction;
    }
    public void SaySomething()
    {
        Debug.Log("Something...");
    }

    // Update is called once per frame
    private void Update()
    {
        if (_direction != 0)
        {
            var delta = _direction * _speed * Time.deltaTime;
            var newXPositions = delta + transform.position.x;
            transform.position = new Vector3(newXPositions, transform.position.y, transform.position.z);
        }
    }
}
