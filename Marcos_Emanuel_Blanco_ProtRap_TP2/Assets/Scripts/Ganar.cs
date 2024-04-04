using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoGanar;

    private void Start()
    {
        textoGanar.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish")){
            textoGanar.gameObject.SetActive(true);
        }
    }
}
