using UnityEngine;

public class HearoInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    
    // void Awake()
    // {
    //     _hero = GetComponent<Hero>(); 
    // }

    // Update is called once per frame
    void Update()
    {
        var horizontel = Input.GetAxis("Horizontal");
        _hero.SetDirection(horizontel);
        
        /*if (Input.GetKey(KeyCode.A))
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
        }*/
    }
}
