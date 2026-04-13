using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOperation : MonoBehaviour
{
    [SerializeField] private float movespeed = 1.0f;
    [SerializeField] private float playerend = 9.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current!=null)
        {
            if (Keyboard.current.aKey.isPressed && transform.position.x >= -playerend)
                transform.position += new Vector3(-movespeed * Time.deltaTime, 0, 0);
            else if(Keyboard.current.dKey.isPressed && transform.position.x <= playerend)
                transform.position += new Vector3(movespeed * Time.deltaTime, 0, 0);

        }
    }
}
