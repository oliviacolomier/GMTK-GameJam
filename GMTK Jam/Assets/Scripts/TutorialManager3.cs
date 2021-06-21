using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager3 : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }
        if (popUpIndex == 0)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                popUpIndex++;
            }

        }
        else if (popUpIndex == 1)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {

            if (Input.GetKeyDown(KeyCode.G))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                popUpIndex++;
        }
        else if (popUpIndex == 4)
        {
            if (Input.GetKeyDown(KeyCode.E))
                popUpIndex++;
        }


    }
}

