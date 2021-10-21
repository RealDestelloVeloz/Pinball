using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaPuntos : MonoBehaviour
{
    private GameObject Bola;
    int puntos;
    GameObject texto;
    TextMesh i;
   // AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }
    void Awake()
    {
        Bola = GameObject.Find("Bola");
        texto = GameObject.Find("Puntos");
        i = texto.GetComponent<TextMesh>();
       
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.collider.name == "Seta")
        {
           
            puntos = puntos + 22;
            i.text = "Puntos: " + puntos;
            Debug.Log("Punto anotado");
            // TODO Añadir diferentes objetos que sumen diferentes puntos
        }
        else if (objetoQueHaEntrado.collider.name == "Rombo")
        {
            puntos = puntos + 15;
            i.text = "Puntos: " + puntos;
        }
    }
}            //Destroy(Bola);
             //  source = GetComponent<AudioSource>();
             //  source.Play(); // Reusar esta parte de codigo para cuando collisione y busquemos sonidos. 
             // Solo añadir el archivo al objeto y quitar el "Sound on awake" de sus propiedades

// Creo una copia del objeto Bola, le pongo el nombre de Bola y la instancio en el mismo lugar que la original

//      Bola = GameObject.Instantiate(Bola);
//  Bola.name = "Bola";

//   Bola.transform.position = new Vector3(9.12f, 4.77f, 13.93f);
//