using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBolaPong : MonoBehaviour
{   
    private Rigidbody2D rb;
    private float velocidadinicial = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //como solo queremos que lo mande hacia una posicion aleatoria al inicio pues lo ponemos en el start 
        Launch();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //esto lo que hace esta mandar un objeto hacia un lado aleatorio y si le ponemos en gravedad 0 etc y le ponemos el material 
    //rebotin pues nos queda como la pelota del pong
    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        rb.velocity = new Vector2(xVelocity, yVelocity) * velocidadinicial;

    }
}
