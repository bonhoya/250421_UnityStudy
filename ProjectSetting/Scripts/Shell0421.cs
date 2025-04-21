using UnityEngine;

public class Shell0421 : MonoBehaviour
{
    [SerializeField] Rigidbody shellRigid;
    [SerializeField] GameObject explosionEffect;
    public int shellDamage = 1;

    private void Update()
    {
        if (shellRigid.velocity.magnitude > 0)
        {
            transform.forward = shellRigid.velocity;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(explosionEffect, transform.position, transform.rotation);

        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            Attack(damagable);
        }

    }

    private void Attack(IDamagable damagable)
    {
        damagable.TakeDamage(gameObject, shellDamage);
    }

}
