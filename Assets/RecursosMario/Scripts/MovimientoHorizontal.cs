    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MovimientoHorizontal : MonoBehaviour
    {
        [SerializeField] float Velocidad = 7f;
        [SerializeField] float potenciaSalto = 10f;
        [SerializeField] bool enSuelo;
        public Animator animator;

    private GameManager1 gameManager;
    Rigidbody2D rb;
        public LayerMask Suelo;
        
        public float logitudRaycast = 0.1f;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager1>();

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("moneda"))
        {
            Destroy(collision.gameObject);

            gameManager.puntuacion();       // Llamar al método puntuacion() en el GameManager

        }


    }
  
        void Update()
        {
       
            Salto();
            MovimientoH();
        

    }

    void MovimientoH()
    {
        float x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("movement",x);

        Vector3 nuevaPosicion =  new Vector3(x, 0, 0) * Velocidad * Time.deltaTime;
            
      
            transform.Translate(nuevaPosicion);
        
    }


   
    
    private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, transform.position + Vector3.down * logitudRaycast);
        }


        private void Salto()
        {
      
             RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, logitudRaycast, Suelo);
            
            enSuelo = hit.collider != null;
            if (enSuelo && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0f, potenciaSalto, 0f), ForceMode2D.Impulse);
            }
        }

    }

