using UnityEngine;

public class Hero : MonoBehaviour
{
    //private float _direction;
    private Vector2 _direction;
    [SerializeField] private float _speed; 
    
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_direction.magnitude > 0)
        {
            var delta = _direction * _speed * Time.deltaTime;
            transform.position = transform.position + new Vector3(delta.x, delta.y, transform.position.z);
        }
    }
    public void SaySomething()
    {
        Debug.Log("Something...");
    }
}
