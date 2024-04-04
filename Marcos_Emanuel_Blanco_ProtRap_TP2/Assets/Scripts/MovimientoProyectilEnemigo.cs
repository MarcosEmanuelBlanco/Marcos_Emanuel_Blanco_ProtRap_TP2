using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProyectilEnemigo : MonoBehaviour
{
    private float randomX;
    // Start is called before the first frame update
    void Start()
    {
        randomX = Random.Range(-0.5f, 0.6f);
    }
    void MovimientoProyEne()
    {
        Vector3 posicionx = transform.position + new Vector3(randomX, -1f, 0f);
        transform.position = posicionx;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        MovimientoProyEne();
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
