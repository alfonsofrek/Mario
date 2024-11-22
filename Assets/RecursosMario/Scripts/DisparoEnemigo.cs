using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Disparoenemigo : MonoBehaviour
{
    [SerializeField] private GameObject proyectilPrefab;
    [SerializeField] private float velocidadDisparo = 10f;
    [SerializeField] private Transform[] puntosDeDisparo;
    [SerializeField] private float contador;

    void Update()
    {
        //esto hace que los disparos de el enemigo salgan en un numero random de tiempo para que sean aleatorios si
        //no los quereis aleatorios igular tiempo a un nuemero que querais 
        float tiempo = Random.Range(1.5f, 6f);
        contador += Time.deltaTime;
        if (contador >= tiempo)
        {
            Disparar();
            contador = 0;
        }


    }

    //la variable disparo tambien podriamos poner la que tenemos en nuestro player por eso no la voy a explicar mucho q  ya esta 
    //explicada y es la 1am quiero ver tiktok pls

    void Disparar()
    {
        if (puntosDeDisparo.Length == 0)
        {
            Debug.LogError("No hay puntos de disparo definidos.");
            return;
        }


        foreach (Transform punto in puntosDeDisparo)
        {
            GameObject bala = Instantiate(proyectilPrefab, punto.position, Quaternion.identity);
            Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
            if (rb != null)
            {

                Vector2 direccion = punto.up;
                rb.velocity = direccion * velocidadDisparo;
            }
            else
            {
                Debug.LogError("El proyectil no tiene un Rigidbody2D.");
            }

        }
    }
}
