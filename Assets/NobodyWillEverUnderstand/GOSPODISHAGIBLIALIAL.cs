using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOSPODISHAGIBLIALIAL : MonoBehaviour
{
    public AudioClip WalkingSound;
    private AudioSource _audioSource;
    public PlayerController _characterController;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_characterController._isMoving)
        {
            _audioSource.volume = 0.5f;
        }
        else
        {
            _audioSource.volume = 0;
        }
    }


}
