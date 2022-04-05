using UnityEngine;

public class HearoInputReader : MonoBehaviour
{
    private Hero _hero;
    
    void Awake()
    {
        _hero = GetComponent<Hero>(); 
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
