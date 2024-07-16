using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGManager : MonoBehaviour
{
    public GameObject Minigame;
    public GameObject OpenMinigame;
   
    void Start()
    {
        Minigame = GameObject.Find("DJPanel");
        OpenMinigame = GameObject.Find("OpenBooth");
        Minigame.SetActive(false);
    }
}
