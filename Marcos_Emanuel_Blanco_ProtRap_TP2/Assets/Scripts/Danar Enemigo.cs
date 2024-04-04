using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanarEnemigo : MonoBehaviour
{
    [SerializeField] private int dagnio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemigo"))
        {
            collision.transform.GetComponent<VidaEnemigo>().RestarVidaEnemigo(-dagnio);
            gameObject.SetActive(false);
        }
    }
}
