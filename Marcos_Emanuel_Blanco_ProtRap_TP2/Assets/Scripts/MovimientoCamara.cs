using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del cubo
    public Vector3 offset = new Vector3(0f, 4f, -10f); // Ajusta la posición relativa de la cámara

    void LateUpdate()
    {
        if (objetivo != null)
        {
            transform.position = objetivo.position + offset;
            transform.LookAt(objetivo.position);
        }
    }
}
