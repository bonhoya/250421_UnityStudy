using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController0421 : MonoBehaviour, IDamagable
{
    [SerializeField] int monsterHP;
    public int MonsterHP { get { return monsterHP; } private set { monsterHP = value; } }

    private void Update()
    {
        
    }

    public void TakeDamage(GameObject Attacker, int damage)
    {
        Debug.Log($"���� ������ ü��:{MonsterHP}, ���� ������{damage}");
        MonsterHP -= damage;
        if(monsterHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
