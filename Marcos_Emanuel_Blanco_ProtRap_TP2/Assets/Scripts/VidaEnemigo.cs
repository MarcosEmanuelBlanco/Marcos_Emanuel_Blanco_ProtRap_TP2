using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    [SerializeField] private int vida;

    public void RestarVidaEnemigo(int dagno)
    {
        if (vida > 0)
        {
            vida += dagno;
        }
        if (vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
