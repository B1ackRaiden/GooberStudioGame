using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//made by Jason Sanchez

public class InteractScript : MonoBehaviour
{
    public GameObject Interact;
    public bool npcIsClose;
    public bool changeSceneIsClose;

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
            {
            Interact.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
        {
            npcIsClose = true;
            Interact.SetActive(true);
        }

        if (other.CompareTag("SceneChange"))
        {
            changeSceneIsClose = true;
            Interact.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
        {
            npcIsClose = false;
            Interact.SetActive(false);
        }

        if (other.CompareTag("SceneChange"))
        {
            changeSceneIsClose = true;
            Interact.SetActive(true);
        }
    }
}
