using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

public Vector3 leftDirection;
public Vector3 rightDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;
        }

         if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
        }
    }
}
