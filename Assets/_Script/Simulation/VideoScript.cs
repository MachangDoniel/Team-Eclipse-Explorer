using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer player;
    public VideoClip[] clips;

    private void Start()
    {
        player.clip =clips[ModelSelector.Instance.modelIndex];
    }
}
