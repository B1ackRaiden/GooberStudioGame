using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGManager : MonoBehaviour
{
    private DropScript DS;
    public GameObject Minigame;
    public GameObject OpenMinigame;
    public int PartsSloted;
    public GameObject TestDialogue;
    public GameObject OpenDialogue;
   
    void Start()
    {
        //minigame script
        PartsSloted = 0;
        Minigame = GameObject.Find("DJPanel");
        OpenMinigame = GameObject.Find("OpenBooth");
        Minigame.SetActive(false);

        //dialogue script
        TestDialogue = GameObject.Find("DialoguePanel");
        OpenDialogue = GameObject.Find("OpenDialogue");
        TestDialogue.SetActive(false);
    }
}
