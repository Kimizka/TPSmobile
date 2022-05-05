using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    [SerializeField]
    private GameObject weapon;
    [SerializeField]
    private Transform pos;
    private AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();    
    }

    public void weaponBtn()
    {
        sound.Play();
        Instantiate(weapon, pos.position, pos.rotation);
    }
}
