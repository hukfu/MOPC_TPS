using UnityEngine;

public class EnemyAscention : MonoBehaviour
{
    public float TimeToDisappear = 1.0f;

    private AudioSource _audioSource;

    private void Start()
    {
        Invoke("Destroy", TimeToDisappear);
        AudioHandler();
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
    private void AudioHandler()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
    }
}
