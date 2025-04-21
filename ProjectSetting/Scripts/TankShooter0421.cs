using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter0421 : MonoBehaviour
{
    [SerializeField] GameObject shellPrefab;
    [SerializeField] Transform muzzlePoint;


    [Range(1, 50)] [SerializeField] float shellSpeed;


    public void Fire()
    {
        GameObject instance = Instantiate(shellPrefab, muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody rigid = instance.GetComponent<Rigidbody>();
        rigid.velocity = muzzlePoint.forward * shellSpeed;
    }
}
