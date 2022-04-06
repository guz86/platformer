using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    

    // Update is called once per frame
    void Update()
    {
        //var horizontal = Input.GetAxis("Horizontal");
        //_hero.SetDirection(horizontal);

    }
    
    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
            
    }
}
