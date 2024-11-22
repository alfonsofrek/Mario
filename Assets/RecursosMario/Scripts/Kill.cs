using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarioCollision : MonoBehaviour
{
    private GameManager1 gameManager; // Referencia a GameManager1

    [SerializeField] private float fuerzaSalto = 5f;
    private Rigidbody2D marioRb;

    void Start()
    {
        // Obtener el componente Rigidbody2D del padre del objeto Mario
        marioRb = GetComponentInParent<Rigidbody2D>();

        // Inicializar el GameManager1 en Start
        gameManager = FindObjectOfType<GameManager1>();

        if (gameManager == null)
        {
            Debug.LogError("No se ha encontrado GameManager1 en la escena.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);  // Destruir el objeto enemigo
            gameManager.puntuacion();       // Llamar al método puntuacion() en el GameManager
            marioRb.velocity = new Vector2(marioRb.velocity.x, fuerzaSalto);  // Aplicar fuerza de salto
        }

    
    }
}
