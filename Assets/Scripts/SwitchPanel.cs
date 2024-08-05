using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
      public GameObject currentpanel;
      public GameObject settingspanel;
    public GameObject questpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        if (currentpanel != null){
            currentpanel.SetActive(false);
        }
        settingspanel.SetActive(true);
    }

    public void QuestPanel()
    {
        questpanel.SetActive(true);
        currentpanel.SetActive(false);
    }
}
