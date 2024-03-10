using UnityEngine;

public class Foods : MonoBehaviour
{
    public float Speed = 1.0f;
    public float Lifetime = 1.0f;
    public float Damage = 1.0f;

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
        transform.position += transform.forward * Speed * Time.fixedDeltaTime;
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
            EnemyHealth.DealDamage(Damage);
            DestroyFoods();
        }
    }
 
}
