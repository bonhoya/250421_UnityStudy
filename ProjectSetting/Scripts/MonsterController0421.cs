using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterController0421 : MonoBehaviour, IDamagable
{
    [SerializeField] Transform playerPosition;
    private float monsterSpeed = 3f;

    [SerializeField] int monsterHP;
    
    public int MonsterHP { get { return monsterHP; } private set { monsterHP = value; } }

    private void Update()
    {
        Trace();
    }

    public void TakeDamage(GameObject Attacker, int damage)
    {
        Debug.Log($"���� ������ ü��:{MonsterHP}, ���� ������{damage}");
        MonsterHP -= damage;
        if(monsterHP == 0)
        {
            Destroy(gameObject);
            GameManager0421.Instance.gameScore++;
            Debug.Log($"���� ���� ���ھ�: {GameManager0421.Instance.gameScore}");
        }
    }

    private void Trace()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position , monsterSpeed * Time.deltaTime);
        transform.LookAt(playerPosition.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
