using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cfggtffgrct : MonoBehaviour
{
    [SerializeField] private UnityEvent _onPlayerEnter;
    [SerializeField] private UnityEvent _onPlayerExit;

    public SceneChanger sceneChanger;

    private AudioSource audioSource;
    private int _ffffffffff = 0;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            _ffffffffff += 1;
            Debug.Log("fYLUEdjkahkabuw");
        }
        if(_ffffffffff == 1)
        {
            _onPlayerEnter.Invoke();
        }
    }


}
