using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] private float tiempoIntervalo;
    private PoolProyectilesEnemigo poolEnemigo;
    private void Awake()
    {
        poolEnemigo = GetComponent<PoolProyectilesEnemigo>();
    }
    void Start()
    {
        InvokeRepeating(nameof(DispararProyectilEnemigo), 0, tiempoIntervalo);
    }
    private void OnEnable()
    {
        InvokeRepeating(nameof(DispararProyectilEnemigo), 0, tiempoIntervalo);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(DispararProyectilEnemigo));
    }

    void DispararProyectilEnemigo()
    {
        GameObject pooledProyectil = poolEnemigo.GetPoolProyectilesEnemigo();
        if(pooledProyectil != null)
        {
            pooledProyectil.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            pooledProyectil.SetActive(true);
        }
    }
}
