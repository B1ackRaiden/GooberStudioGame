using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitControl : MonoBehaviour
{

    public GameObject ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        
       ExitButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}