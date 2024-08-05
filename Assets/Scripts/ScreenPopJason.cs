using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made By Jason Sanchez

public class ScreenPopJason : MonoBehaviour
{
    public GameObject Minigame;

    public bool playerIsClose;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            Minigame.SetActive(true);
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
}
