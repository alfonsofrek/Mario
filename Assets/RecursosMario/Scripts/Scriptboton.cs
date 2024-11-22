using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scriptboton : MonoBehaviour
{
    // Start is called before the first frame update
    //para un boton solo tenemos q ponerle onClick() dentro de este mismo no va por ningun script y ejecutara el script que queramos cuando le de
    //aqui al darle al boton por ejemplo nos cambiara de escena a la que pongamos dentro del boton
    public void CambiarAScena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
