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
        if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("coucou");
                spwanSoul();
                if (bodyPlayer.tag == "Yellow")
                    bodyPlayer.tag = "Green";
                else if (bodyPlayer.tag == "Green")
                    bodyPlayer.tag = "Yellow";
                SoundManager.Playsound("SplitandFusion");
            }
        if (soulIsActive && Input.GetKeyDown(KeyCode.G))
        {
            SwitchControl();
        }
    }

    void spwanSoul() {
        if (!soulIsActive)
        {
            SwitchControl();
            soulPlayer.SetActive(true);
            soulPlayer.transform.position = bodyPlayer.transform.position;
            soulIsActive = true;
            bodyPlayer.GetComponent<BodyBehavior>().CanJump = false;
        }
        else if(soulIsActive)
        {
            if (selectedControl == "ghost")
            {
                SwitchControl();
            }
            soulPlayer.SetActive(false);
            soulIsActive = false;
            bodyPlayer.GetComponent<BodyBehavior>().CanJump = true;

        }
    }

    void SwitchControl() {
        if (selectedControl == "body")
        {
            bodyPlayer.GetComponent<BodyBehavior>().CanMove = false;
            soulPlayer.GetComponent<GhostBehavior>().CanMove = true;
            selectedControl = "ghost";
        }
        else if (selectedControl == "ghost")
        {
            bodyPlayer.GetComponent<BodyBehavior>().CanMove = true;
            soulPlayer.GetComponent<GhostBehavior>().CanMove = false;
            selectedControl = "body";
        }
    }
}
