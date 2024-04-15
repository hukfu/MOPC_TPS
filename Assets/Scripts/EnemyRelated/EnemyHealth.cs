using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 1.0f;
    public GameObject Ascention;
    public GameObject Main;

    public void DealDamage(float Damage)
    {
        Value -= Damage;
        if (Value <= 0)
        {
            Destroy(gameObject);
            var asc = Instantiate(Ascention);
            asc.transform.position = Main.transform.position;
        }
    }
}
