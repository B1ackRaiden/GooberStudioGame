using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPop : MonoBehaviour
{
    public GameObject Minigame;
    public GameObject Minigame;

    public bool playerIsClose;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            playerIsClose = true;
            interactBtn.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            Minigame.SetActive(false);
        }
    }
    // public void PressButton ()
    // inert what should happen when i press this button
    //assign this function to OnClick 
}