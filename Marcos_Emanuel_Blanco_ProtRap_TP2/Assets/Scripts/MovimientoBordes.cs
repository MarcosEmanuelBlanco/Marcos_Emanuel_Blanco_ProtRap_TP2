using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBordes : MonoBehaviour
{
    private Vector2 movVert = Vector2.up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Mover()
    {
        Vector3 posicion = transform.position + new Vector3(0f, 0f/*movVert.y*/, 0f);
        transform.position = posicion;
    }
    private void FixedUpdate()
    {
        Mover();
    }
}
