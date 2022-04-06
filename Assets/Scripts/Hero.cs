using UnityEngine;
using UnityEngine.InputSystem;

public class Hero : MonoBehaviour
{
    private float _direction;
    [SerializeField] private float _speed;

     public void SetDirection(float direction)
     {
         _direction = direction;
     }

    private void Update()
    {
        // if (_direction != 0)
        // {
        //     var delta = _direction * _speed * Time.deltaTime;
        //     var newXPosition = transform.position.x + delta;
        //     transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        // }
    }

} 