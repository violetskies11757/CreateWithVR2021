using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketSounds : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip enterSound;
    public AudioClip exitSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayEnterSound()
    {
        audioSource.PlayOneShot(enterSound);
    }

    public void PlayExitSound()
    {
        audioSource.PlayOneShot(exitSound);
    }
}
