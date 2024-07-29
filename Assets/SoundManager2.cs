using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager2 : MonoBehaviour
{
    [SerializeField] Slider SoundSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("soundVolume"))
        { 
           PlayerPrefs.SetFloat("soundVolume", 1);
           Load();
        }

        else
        {
            Load();
        }
    }

   public void ChangeVolume()
   {
          AudioListener.volume = SoundSlider.value;
          Save();
   }

   private void Load()
   {
          SoundSlider.value = PlayerPrefs.GetFloat("soundVolume");
   }

   private void Save()
   {
          PlayerPrefs.SetFloat("soundVolume", SoundSlider.value);
   }
}
