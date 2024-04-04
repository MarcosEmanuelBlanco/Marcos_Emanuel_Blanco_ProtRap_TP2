using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    private PoolProyectilesNave poolNave;
    // Start is called before the first frame update
    void Start()
    {
        poolNave = GetComponent<PoolProyectilesNave>();
    }

    // Update is called once per frame
    void Update()
    {
        DispararProyNave();
    }

    void DispararProyNave()
    {
        GameObject pooledProyNave = poolNave.GetPoolProyectilesNave();
        if(pooledProyNave != null && Input.GetKeyDown(KeyCode.Space))
        {
            pooledProyNave.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            pooledProyNave.SetActive(true);
        }
    }
}
