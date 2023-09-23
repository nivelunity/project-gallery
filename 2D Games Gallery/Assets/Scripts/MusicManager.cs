using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioClips;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeBackgroundMusic(int clipIndex)
    {
        if (clipIndex > audioClips.Count) { return; }

        audioSource.clip = audioClips[clipIndex];
        audioSource.Play();
    }

}
