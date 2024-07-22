using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{

    public ButtonPanel buttonPanel; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            buttonPanel.gameObject.setActive(!buttonPanel.gameObject.activeSelf);
        }
    }
}
