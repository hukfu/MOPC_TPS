using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI clockText;

    public int Hour = 9;
    public int Minute = 0;

    private void Start()
    {
        clockText = GetComponent<TextMeshProUGUI>();
        InvokeRepeating("UpdateClock", 0f, 0.5f);
    }

    private void UpdateClock()
    {
        string hour = Hour.ToString("00");
        string minute = Minute.ToString("00");
        Minute += 1;
        if (Minute >= 60)
        {
            Minute = 0;
            Hour += 1;
        }

        clockText.text = hour + ":" + minute;
    }
}
