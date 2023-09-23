using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    [SerializeField] MusicManager musicManager;

    [SerializeField]
    [Range(0,9)]
    public int musicCount = 0;

    private void OnTriggerEnter(Collider other)
    {

        if (!other.CompareTag("Player")) { return; }

        musicManager.ChangeBackgroundMusic(musicCount);
    }
}
