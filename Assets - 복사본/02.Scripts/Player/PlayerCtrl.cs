using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    private JoyControll joyCtrl;
    [SerializeField]
    private float moveSpeed = 0.0f;
    [SerializeField]
    private Animator playerAnim;

    private void Update()
    {
        float x = joyCtrl.Horizontal();
        float z = joyCtrl.Vertical();

        if (x == 0 || z == 0)
        {
            playerAnim.SetInteger("RUN", 0);
        }
        else
        {
            PlayerMove(x, z);
        }
    }

    private void PlayerMove(float x, float z)
    { 
        if (z > 0)
        {
            playerAnim.SetInteger("RUN", 1);
        }
        if (z < 0)
        {
            playerAnim.SetInteger("RUN", -1);
        }
        transform.position += new Vector3(x, 0, z) * moveSpeed * Time.deltaTime;
    }
}
