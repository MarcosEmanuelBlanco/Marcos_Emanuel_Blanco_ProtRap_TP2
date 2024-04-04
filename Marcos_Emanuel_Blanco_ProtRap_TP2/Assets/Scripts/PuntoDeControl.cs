using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PuntoDeControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoCuenta;
    [SerializeField] private TextMeshProUGUI textoRespuesta1;
    [SerializeField] private TextMeshProUGUI textoRespuesta2;
    [SerializeField] private TextMeshProUGUI textoRespuesta3;
    [SerializeField] private GameObject conjuntoEnemigos;
    [SerializeField] private GameObject nave;
    private int valor1;
    private int valor2;
    private int resultado;
    private int determinarCorrecta;
    private int respuesta1;
    private int respuesta2;
    private int respuesta3;
    private int miRespuesta;
    private bool habilitarRespuesta;
    private bool yaRespondio;
    // Start is called before the first frame update
    void Start()
    {
        conjuntoEnemigos.SetActive(false);
        ReestablecerValores();
    }
    private void Update()
    {
        if(habilitarRespuesta)
        {
            ElegirRespuesta();
            ConfirmarRespuesta();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            textoCuenta.text = valor1.ToString() + " + " + valor2.ToString();
            textoRespuesta1.text = "1: " + respuesta1.ToString();
            textoRespuesta2.text = "2: " + respuesta2.ToString();
            textoRespuesta3.text = "3: " + respuesta3.ToString();
            textoCuenta.gameObject.SetActive(true);
            textoRespuesta1.gameObject.SetActive(true);
            textoRespuesta2.gameObject.SetActive(true);
            textoRespuesta3.gameObject.SetActive(true);
            conjuntoEnemigos.SetActive(true);
            habilitarRespuesta = true;
        }
    }

    private void ElegirRespuesta()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) { 
            miRespuesta += respuesta1;
            yaRespondio = true;

        }else if(Input.GetKeyDown(KeyCode.Alpha2)) { 
            miRespuesta += respuesta2;
            yaRespondio = true;

        }else if(Input.GetKeyDown(KeyCode.Alpha3)) { 
            miRespuesta += respuesta3;
            yaRespondio = true;
        }

    }

    private void ConfirmarRespuesta()
    {
        if(miRespuesta == resultado && yaRespondio)
        {
            Debug.Log("Bien");
            conjuntoEnemigos.SetActive(false);
            ReestablecerValores();
        }
        else if(miRespuesta != resultado && yaRespondio)
        {
            Debug.Log("Mal");
            nave.GetComponent<VidasNave>().RestarVidas();
            ReestablecerValores();
        }
    }

    private void ReestablecerValores()
    {
        textoCuenta.gameObject.SetActive(false);
        textoRespuesta1.gameObject.SetActive(false);
        textoRespuesta2.gameObject.SetActive(false);
        textoRespuesta3.gameObject.SetActive(false);
        valor1 = Random.Range(10, 51);
        valor2 = Random.Range(10, 51);
        resultado = valor1 + valor2;
        determinarCorrecta = Random.Range(1, 4);
        if (determinarCorrecta == 1)
        {
            Debug.Log(determinarCorrecta);
            respuesta1 = resultado;
            respuesta2 = Random.Range(10, resultado - 1);
            respuesta3 = Random.Range(resultado + 1, 101);
        }
        else if (determinarCorrecta == 2)
        {
            Debug.Log(determinarCorrecta);
            respuesta1 = Random.Range(10, resultado - 1);
            respuesta2 = resultado;
            respuesta3 = Random.Range(resultado + 1, 101);
        }
        else if (determinarCorrecta == 3)
        {
            Debug.Log(determinarCorrecta);
            respuesta1 = Random.Range(10, resultado - 1);
            respuesta2 = Random.Range(resultado + 1, 101);
            respuesta3 = resultado;
        }
        miRespuesta = 0;
        habilitarRespuesta = false;
        yaRespondio = false;
    }

    private void OnBecameVisible()
    {
        gameObject.SetActive(true);
    }
}
