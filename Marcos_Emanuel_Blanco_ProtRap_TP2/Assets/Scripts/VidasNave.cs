using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class VidasNave : MonoBehaviour
{
    private int vidas;
    [SerializeField] private TextMeshProUGUI textoVidas;
    [SerializeField] private TextMeshProUGUI textoDerrota;
    [SerializeField] private UnityEvent<string> OnHealthChange;
    // Start is called before the first frame update

    void Start()
    {
        vidas = 3;
        OnHealthChange.Invoke(vidas.ToString());
        textoDerrota.gameObject.SetActive(false);
    }

    public void RestarVidas()
    {
        if(vidas > 0)
        {
            vidas -=1;
            OnHealthChange.Invoke(vidas.ToString());
        }
        if(vidas <= 0)
        {
            OnHealthChange.Invoke(vidas.ToString());
            textoDerrota.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
