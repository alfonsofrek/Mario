using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private GameObject proyectilPrefab; // El prefab del proyectil
    [SerializeField] private float velocidadDisparo = 10f; // Velocidad del proyectil
    [SerializeField] private Transform puntoDeDisparo; // Punto desde donde se disparará
   private float tiempoEspera ;
    float contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        tiempoEspera = UnityEngine.Random.Range(7, 12);
    }

    void Update()
    {
        contador += Time.deltaTime;

        if (contador>tiempoEspera)
                                       { 
            Disparar();
            contador = 0;
            tiempoEspera = UnityEngine.Random.Range(7,12);
        }
    }
    void Disparar()
    {
        //para el punto de disparo creais un gameobject vacio desde el objeto q querais q dispare y lo meteis
        //y el proyectil lo que querais que se dispare
        GameObject bala = Instantiate(proyectilPrefab, puntoDeDisparo.position, Quaternion.identity);

        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(velocidadDisparo, 0);
           
        }
    }
}
