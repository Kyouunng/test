using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager instance;
    
    public AudioClip jumpSound;
    
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance ==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound, 0.5f);
    }
}
