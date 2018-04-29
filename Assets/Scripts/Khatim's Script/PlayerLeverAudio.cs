using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeverAudio : MonoBehaviour
{
    public AudioSource audSource;
    public AudioClip audClip;
    private bool hasPlayed;

    void Start()
    {
        audSource = GetComponent<AudioSource>();
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !hasPlayed)
        {
            audSource.PlayOneShot(audClip);
            hasPlayed = true;
        }
    }
}
