using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGManager : MonoBehaviour
{
    private DropScript DS;
    public GameObject Minigame;
    public GameObject OpenMinigame;
    public int PartsSloted;
   
    void Start()
    {
        PartsSloted = 0;
        Minigame = GameObject.Find("DJPanel");
        OpenMinigame = GameObject.Find("OpenBooth");
        Minigame.SetActive(false);
    }
}
