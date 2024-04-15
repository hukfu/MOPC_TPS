using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int Hour = 9;
    public int Minute = 0;

    private TextMeshProUGUI _clockText;

    private void Start()
    {
        _clockText = GetComponent<TextMeshProUGUI>();
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
        _clockText.text = hour + ":" + minute;
    }
}
