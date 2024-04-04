using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    [SerializeField] private GameObject jugador;

    void Update()
    {
        if(jugador == null && Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarEscena();
        }
    }

    private void ReiniciarEscena()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (jugador == null)
        {
            Instantiate(jugador);
        }
    }
}
