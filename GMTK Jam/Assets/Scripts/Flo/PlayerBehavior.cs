using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject soulPlayer;
    public GameObject bodyPlayer;
    private bool soulIsActive;
    private string selectedControl;
    // Start is called before the first frame update
    void Start()
    {
        soulPlayer.SetActive(false);
        soulIsActive = false;
        selectedControl = "body";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("coucou");
                spwanSoul();
                bodyPlayer.tag = "Yellow";
            }
        if (soulIsActive && Input.GetKeyDown(KeyCode.G))
            switchControl();
        if(soulIsActive)
            bodyPlayer.GetComponent<BodyBehavior>().CanJump = false;
        else
            bodyPlayer.GetComponent<BodyBehavior>().CanJump = true;

    }

    void spwanSoul() {
        if (!soulIsActive)
        {
            soulPlayer.SetActive(true);
            soulPlayer.transform.position = bodyPlayer.transform.position;
            soulIsActive = true;
        }
        else if(soulIsActive)
        {
            soulPlayer.SetActive(false);
            soulIsActive = false;
        }
    }

    void switchControl() {
        if (selectedControl == "body")
        {
            selectedControl = "ghost";
        }
        else if (selectedControl == "ghost")
        {
            selectedControl = "body";
        }
    }
}
