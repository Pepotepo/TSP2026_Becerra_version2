using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PianoAR : MonoBehaviour
{
    //Creamos un arreglo para almacenar audio
    public AudioClip[] clips;
    public AudioSource audioSource;
    string btnName;




    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Input.GetMouseButtonDown detecta si presionamos el botón del maus. Cero es el índice del botón derecho
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Crea un rayo a partir de donde se dio el click
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))//Simula la física del rayo virtual que creamos a partir del punto donde se dio click en la cámara y si hay colición lo asigna a hit
            {
                btnName = hit.transform.name;//Accede al nombre del objeto

                switch (btnName)
                {
                    case "do":
                        audioSource.clip=clips[0];
                        audioSource.Play();
                        break;
                    case "re":
                        audioSource.clip = clips[1];
                        audioSource.Play();
                        break;
                    case "mi":
                        audioSource.clip = clips[2];
                        audioSource.Play();
                        break;
                    case "fa":
                        audioSource.clip = clips[3];
                        audioSource.Play();
                        break;
                    case "sol":
                        audioSource.clip = clips[4];
                        audioSource.Play();
                        break;
                    case "la":
                        audioSource.clip = clips[5];
                        audioSource.Play();
                        break;
                    case "si":
                        audioSource.clip = clips[6];
                        audioSource.Play();
                        break;
                    default:
                        break;

                }

            }
        }
        //Consifuración para teléfono
        else if (Input.touchCount>0 && Input.touches[0].phase==TouchPhase.Began)//Detecta el primer toque
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;

                switch (btnName)
                {
                    case "do":
                        audioSource.clip = clips[0];
                        audioSource.Play();
                        break;
                    case "re":
                        audioSource.clip = clips[1];
                        audioSource.Play();
                        break;
                    case "mi":
                        audioSource.clip = clips[2];
                        audioSource.Play();
                        break;
                    case "fa":
                        audioSource.clip = clips[3];
                        audioSource.Play();
                        break;
                    case "sol":
                        audioSource.clip = clips[4];
                        audioSource.Play();
                        break;
                    case "la":
                        audioSource.clip = clips[5];
                        audioSource.Play();
                        break;
                    case "si":
                        audioSource.clip = clips[6];
                        audioSource.Play();
                        break;
                    default:
                        break;

                }

            }
        }


    }
}
