using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectilnubes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("eliminador"))
        {
            Destroy(gameObject);
        }

    }



    public void Init()
    {
    }
}
