﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicBetweenScenes : MonoBehaviour
{

    private static PlayMusicBetweenScenes instance = null;
    public static PlayMusicBetweenScenes Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {

    }

}