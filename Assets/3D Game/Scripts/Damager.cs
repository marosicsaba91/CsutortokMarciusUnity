using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1;

    void OnTriggerEnter(Collider other)
    {
        Damageable damageable =
            other.GetComponent<Damageable>();

        if (damageable != null)
        {
            damageable.Damage(damage);
        }
    }
}
