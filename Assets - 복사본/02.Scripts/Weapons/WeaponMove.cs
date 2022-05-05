using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * speed);
        Destroy(gameObject, 3.0f);    
    }
}
