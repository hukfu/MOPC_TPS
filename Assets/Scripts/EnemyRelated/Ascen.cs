using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascen : MonoBehaviour
{
    public float Lifetime = 1.0f;

    private void Start()
    {
        Invoke("Destroy", Lifetime);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
