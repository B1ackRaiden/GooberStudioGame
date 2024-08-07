using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//made Jason Sanchez

public class PlayerMovementScript : MonoBehaviour
{

    public Vector3 leftDirection;
    public Vector3 rightDirection;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;
            spriteRenderer.flipX = true;
        }

        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
            spriteRenderer.flipX = false;
           
        }
    }
}
