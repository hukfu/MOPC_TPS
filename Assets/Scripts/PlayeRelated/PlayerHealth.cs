using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float Maxvalue = 3.0f;
    public float value;
    
    public int HealthNum;
    public int NumOfHearts;

    public Image[] Hearts;
    public Sprite HeartFull;
    public Sprite HeartEmpty;

    private AudioSource _audioSource;

    private void Start()
    {
        value = Maxvalue;
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < value)
            {
                Hearts[i].sprite = HeartFull;
            }
            else
            {
                Hearts[i].sprite = HeartEmpty;
            }
        }
    }

    public void DealDamage(float Damage)
    {
        value -= Damage;
        _audioSource.Play();
        if (value <= 0)
        {
            SceneManager.LoadScene("Losing");
        }
    }
}
