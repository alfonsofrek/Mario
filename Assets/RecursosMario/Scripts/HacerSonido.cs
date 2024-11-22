using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerSonido : MonoBehaviour
{
    public AudioClip tone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //simplemente ponemos cuando queremos que se ejecute por ejemplo
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            {
                hacerSonido();
                //si pulsasemos el escape sonaria
            }

        }

    }
    void hacerSonido()
    {
        //con esto podemos hacer que suene un sonido que ya teniamos descargado
        //casi vomito los espagetis tirandome un eructo
        AudioSource.PlayClipAtPoint(tone, transform.position);


    }
    //esto para que si detectamos una colision y queremos que suene un sonido
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("palas"))
        {
            hacerSonido();

        }
    }
}
