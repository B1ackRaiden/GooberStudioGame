using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialScreenPop : MonoBehaviour
{
    private GameObject TestDialogue;
    
    void awake()
    {
        TestDialogue = GameObject.Find("DialoguePanel");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TestDialogue.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TestDialogue.SetActive(false);
        }
    }
}
