using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProximityButton : MonoBehaviour
{

    public GameObject char_walk_right;

    public Button interactionButton;

    public float activiationDistance = 2.0f;


    // Update is called once per frame
    void Update()
    {
        if (char_walk_right != null && interactionButton != null)
        {
            float distance = Vector3.Distance(transform.position, char_walk_right.transform.position);

            if (distance <= activiationDistance)
            {
                interactionButton.gameObject.SetActive(true);
            }
            else
            {
            interactionButton.gameObject.SetActive(false);
            }
            
        }
    }
}
