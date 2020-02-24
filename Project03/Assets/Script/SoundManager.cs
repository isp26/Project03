using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource crashSound;
    public AudioSource errorSound;

    public static SoundManager Instance;
    public AudioSource backGoundMusic;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void crash()
    {
        crashSound.Play();
    }
    public void error()
    {
        errorSound.Play();
    }
}

