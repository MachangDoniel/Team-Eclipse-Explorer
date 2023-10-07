using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer player;
    public VideoClip clip;
    public bool playOnEnable = false;

    private void OnEnable()
    {
        if(playOnEnable)
        {
            Play();
        }
    }

    void Play()
    {
        player.clip = clip;
    }

}
