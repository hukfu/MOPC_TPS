using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyAI AppleWanter;
    public EnemyAI TeaWanter;
    public EnemyAI SaladWanter;

    public PlayerController Player;

    public float Delay;

    private EnemyAI _mobToSpawn;

    private float _time = 0;

    private void Update()
    {
        DelayTime();
        DelayTiming();
        EnemySpawn();
    }

    private void EnemySpawn()
    {
        if (_time > Delay)
        {
            int randomIndex = Random.Range(0, 3);
            if (randomIndex == 0)
            {
                _mobToSpawn = AppleWanter;
            }
            else if (randomIndex == 1)
            {
                _mobToSpawn = TeaWanter;
            }
            else if (randomIndex == 2)
            {
                _mobToSpawn = SaladWanter;
            }
            var enemy = Instantiate(_mobToSpawn);
            enemy.transform.position = transform.position;
            enemy.Player = Player;
            _time = 0;
        }
    }
    private void DelayTiming()
    {
        _time += Time.deltaTime;
    }

    private void DelayTime()
    {
        Delay = Random.Range(13, 20);
    }
}
