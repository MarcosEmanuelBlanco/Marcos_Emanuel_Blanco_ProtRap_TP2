using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform objetivo;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            Vector3 posicionx = transform.position + new Vector3(0f, 0.003f, 0f);
            transform.position = posicionx;
        }
    }
}
