using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascen : MonoBehaviour
{
    public float Lifetime = 1.0f;
    private AudioSource _audioSource;

    private void Start()
    {
        Invoke("Destroy", Lifetime);
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
