using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float Maxvalue = 3.0f;
    public float value;
    
    public int HealthNum;
    public int NumOfHearts;

    public Image[] Hearts;
    public Sprite HeartFull;
    public Sprite HeartEmpty;

    private void Start()
    {
        value = Maxvalue;
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
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
