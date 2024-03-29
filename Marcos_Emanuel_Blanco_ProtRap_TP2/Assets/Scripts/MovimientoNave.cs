using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    private float direccion;
    private Vector2 movVert = Vector2.up;
    [SerializeField] private Transform bordeIzquierdo;
    [SerializeField] private Transform bordeDerecho;
    private void Start()
    {
        
    }
    private void Mover()
    {
        direccion = Input.GetAxis("Horizontal");
        Vector3 posicionx = transform.position + new Vector3(direccion, 0f /*movVert.y*/, 0f);
        posicionx.x = Mathf.Clamp(posicionx.x, bordeIzquierdo.position.x, bordeDerecho.position.x);
        transform.position = posicionx;
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Mover();
    }
}
