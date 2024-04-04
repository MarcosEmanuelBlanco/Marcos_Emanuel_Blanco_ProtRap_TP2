using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolProyectilesEnemigo : MonoBehaviour
{
    [SerializeField] private GameObject proyectilEnemigo;
    [SerializeField] private int tamanoPoolProyectilesEnemigo = 20;
    private List<GameObject> poolProyectilesEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        poolProyectilesEnemigo = new List<GameObject>();
        for(int i = 0; i < tamanoPoolProyectilesEnemigo; i++)
        {
            GameObject obj = Instantiate(proyectilEnemigo);
            obj.SetActive(false);
            poolProyectilesEnemigo.Add(obj);
        }
    }
    
    public GameObject GetPoolProyectilesEnemigo()
    {
        foreach(GameObject obj in poolProyectilesEnemigo)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }
        return null;
    }
}
