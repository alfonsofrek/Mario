using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using Unity.VisualScripting;


public class GameManager1 : MonoBehaviour
{

    public int score = 0;               // Puntos del jugador
    public int touchCount = 3;          // Número de toques de Gumba
    public TextMeshProUGUI scoreText;   // Referencia a TextMeshProUGUI para mostrar el puntaje
    public GameObject gameOverUI;       // UI para mostrar el fin del juego
    public GameObject levelCompleteUI;  // UI para mostrar cuando se completa el nivel
    private bool gameOver = false;      // Estado del juego
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
        if (touchCount == 0)
        {
            SceneManager.LoadScene("fin");



        }
        if (score > 20)
        {
            SceneManager.LoadScene("FINS");


        }
    }
    
    
    public void puntuacion()
    {
        score += 5;
    }

    void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }


    public void vida()
    {
        touchCount--;
       





        }
    void btnJugar()
    {
        SceneManager.LoadScene("mario");

    }
    void btnmenu()
    {
        SceneManager.LoadScene("Inicio");

    }
}

