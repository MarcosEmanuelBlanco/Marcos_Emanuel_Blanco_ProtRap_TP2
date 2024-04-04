using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI miTextoVida;
    public void ActualizarTextoHUDVida(string nuevoTexto)
    {
        miTextoVida.text = "Vidas: " + nuevoTexto;
    }
}
