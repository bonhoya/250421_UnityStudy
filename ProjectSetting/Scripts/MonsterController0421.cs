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
        Debug.Log($"현재 몬스터의 체력:{MonsterHP}, 받은 데미지{damage}");
        MonsterHP -= damage;
        if(monsterHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
