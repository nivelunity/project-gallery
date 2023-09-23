using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioClips;

    private AudioSource audioSource;
    private int currentSong = 10;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        ChangeBackgroundMusic(0);
    }

    public void ChangeBackgroundMusic(int clipIndex)
    {
        if (clipIndex == currentSong) { return; }

        currentSong = clipIndex;
        audioSource.clip = audioClips[clipIndex];
        audioSource.Play();
    }

}
