using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public GameObject Interact;
    public bool npcIsClose;

    void Update()
    {
        if (npcIsClose)
        {
            Interact.SetActive(true);
        }
        
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
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
        {
            npcIsClose = false;
            Interact.SetActive(false);
        }
    }
}
