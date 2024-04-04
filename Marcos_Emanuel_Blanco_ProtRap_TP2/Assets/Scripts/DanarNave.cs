using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañarNave : MonoBehaviour
{

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("BordeInferior"))
        {
            collision.transform.GetComponent<VidasNave>().RestarVidas();
            gameObject.SetActive(false);
        }
    }
}
