using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPop : MonoBehaviour
{
    public GameObject Minigame;
    public GameObject interactBtn;

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
            interactBtn.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            Minigame.SetActive(false);
            interactBtn.SetActive(false);
        }
    }
}

