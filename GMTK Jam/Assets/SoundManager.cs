using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip SplitandFusion;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        SplitandFusion = Resources.Load<AudioClip>("SplitandFusion");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playsound (string clip)
    {
        audioSrc.PlayOneShot(SplitandFusion);
    }
}
