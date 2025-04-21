using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Adapter0421 : MonoBehaviour, IDamagable
{
    public UnityEvent<GameObject, int> OnDamaged;
    public void TakeDamage(GameObject Attacker, int damage)
    {
        OnDamaged?.Invoke(Attacker, damage);
    }
}
