using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{

    [SerializeField] private Hero _hero;
    // Update is called once per frame
    /*private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        _hero.SetDirection(horizontal);
        
        if (Input.GetKey(KeyCode.A))
        {
            _hero.SetDirection(-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _hero.SetDirection(1);
        }
        else
        {
            _hero.SetDirection(0);
        }
    }*/

    public void OnHorizontalMovement(InputAction.CallbackContext context )
    {
        var direction = context.ReadValue<float>();
        _hero.SetDirection(direction);
    }
}
