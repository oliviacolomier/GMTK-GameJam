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
        {
            switchControl();
        }
           
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
            if (selectedControl == "body")
            {
                switchControl();
            }
            soulPlayer.SetActive(false);
            soulIsActive = false;
        }
    }

    void switchControl() {
        if (selectedControl == "body")
        {
            bodyPlayer.GetComponent<BodyBehavior>().CanMove = false;
            soulPlayer.GetComponent<BodyBehavior>().CanMove = true;
            selectedControl = "ghost";
        }
        else if (selectedControl == "ghost")
        {
            bodyPlayer.GetComponent<BodyBehavior>().CanMove = true;
            soulPlayer.GetComponent<BodyBehavior>().CanMove = false;
            selectedControl = "body";
        }
    }
}
