using UnityEngine;
using TMPro;
public class ptr : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private bool _isTextOn = false;
    private bool _canTextBeOn = false;


    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        Invoke("Text", 2.5f);
        InvokeRepeating("pulpit", 0f, 0.7f);
    }
    private void Update()
    {
        if(_isTextOn)
        {
            _text.text = "press EEEEEEEEEE to wake up";
        }
        else
        {
            _text.text = "";
        }
    }

    private void Text()
    {
        _canTextBeOn = true;
    }
    private void pulpit()
    {
        if (_canTextBeOn)
        {
            _isTextOn = !(_isTextOn);
        }
    }
}
