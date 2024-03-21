using UnityEngine;

public class Foods : MonoBehaviour
{
    public float Speed = 1.0f;
    public float Lifetime = 1.0f;
    public float Damage = 1.0f;

    public bool IsApples;
    public bool IsTea;
    public bool IsSalad;

    private void Start()
    {
        Invoke("DestroyFoods", Lifetime);
    }
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void MoveFixedUpdate()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerCheck(collision);
        DamageEnemy(collision);
    }

    private void DestroyFoods()
    {
        Destroy(gameObject);
    }
    private void PlayerCheck(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            return;
        }
        else
        {
            DestroyFoods();
        }
    }
    private void DamageEnemy(Collision collision)
    {
        var EnemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (EnemyHealth != null)
        {
            if (collision.collider.CompareTag("AppleWanter"))
            {
                if (IsApples)
                {
                    EnemyHealth.DealDamage(Damage);
                    DestroyFoods();
                }
                else
                {
                    DestroyFoods();
                }
            }
            else if (collision.collider.CompareTag("TeaWanter"))
            {
                if (IsTea)
                {
                    EnemyHealth.DealDamage(Damage);
                    DestroyFoods();
                }
                else
                {
                    DestroyFoods();
                }
            }
            else if (collision.collider.CompareTag("SaladWanter"))
            {
                if (IsSalad)                {
                    EnemyHealth.DealDamage(Damage);
                    DestroyFoods();
                }
                else
                {
                    DestroyFoods();
                }
            }
        }
    }
}
