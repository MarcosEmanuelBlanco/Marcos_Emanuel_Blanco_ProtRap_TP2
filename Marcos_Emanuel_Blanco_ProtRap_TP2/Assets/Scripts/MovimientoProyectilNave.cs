using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoProyectilNave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void MovimientoProyNave()
    {
        Vector3 posicionx = transform.position + new Vector3(0f, 1f, 0f);
        transform.position = posicionx;
    }
    // Update is called once per frame
    void FixedUpdate()//mover al fixed
    {
        MovimientoProyNave();
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
