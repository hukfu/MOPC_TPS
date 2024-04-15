using UnityEngine;

public class GREHFHDGH : MonoBehaviour
{
    public AudioClip WalkingSound;
    private AudioSource _audioSource;
    public PlayerController _characterController;

    private bool _GO = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void FFDFDFFDFF()
    {
        if(_GO)
        _audioSource.Play();
    }

    public void goplease()
    {
        _GO = true;
        InvokeRepeating("FFDFDFFDFF", 0f, 9.5f);
    }
    public void NOTgoplease()
    {
        _GO = false;
    }

}
