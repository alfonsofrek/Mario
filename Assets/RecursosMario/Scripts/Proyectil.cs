using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private GameManager1 gameManager;

    // Llamamos a FindObjectOfType en un lugar adecuado, como Start o Awake
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager1>();

        if (gameManager == null)
        {
            Debug.LogError("No se ha encontrado GameManager1 en la escena.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);

        if (collision.CompareTag("player"))
        {
            if (gameManager != null)
            {
                gameManager.vida(); // Llamamos al método vida del GameManager
            }
        }

        if (collision.CompareTag("eliminador"))
        {
            Destroy(gameObject); // Destruimos el proyectil
        }
    }

    public void Init()
    {
        // Aquí puedes agregar inicialización adicional si es necesario
    }
}
