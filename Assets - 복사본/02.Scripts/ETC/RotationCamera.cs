using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{
    [SerializeField]
    private int dir;
    private bool downKey;
    

    private void Update()
    {
        if (downKey)
        {
            transform.Rotate(new Vector3(0, dir * 100f * Time.deltaTime, 0));
        }
    }

    public void PointerDown()
    {
        downKey = true;
    }

    public void PointerUp()
    {
        downKey = false;
    }
}
