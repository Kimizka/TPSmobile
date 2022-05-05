using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    private JoyControll joyCtrl;
    [SerializeField]
    private float moveSpeed = 0.0f;

    private void Update()
    {
        float x = joyCtrl.Horizontal();
        float z = joyCtrl.Vertical();

        PlayerMove(x, z);
        
    }

    private void PlayerMove(float x, float z)
    { 
        transform.position += (transform.right * x + transform.forward * z) * moveSpeed * Time.deltaTime;
    }
}
