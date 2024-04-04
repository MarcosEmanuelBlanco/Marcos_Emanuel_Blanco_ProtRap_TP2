using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolProyectilesNave : MonoBehaviour
{
    [SerializeField] private GameObject proyectilNave;
    [SerializeField] private int tamanoPoolProyectilesNave = 20;
    private List<GameObject> poolProyectilesNave;
    // Start is called before the first frame update
    void Start()
    {
        poolProyectilesNave = new List<GameObject>();
        for (int i = 0; i < tamanoPoolProyectilesNave; i++)
        {
            GameObject obj = Instantiate(proyectilNave);
            obj.SetActive(false);
            poolProyectilesNave.Add(obj);
        }
    }

    public GameObject GetPoolProyectilesNave()
    {
        foreach (GameObject obj in poolProyectilesNave)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }
        return null;
    }
}
