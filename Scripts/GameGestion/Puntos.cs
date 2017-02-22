using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    public static int puntos;
    public Text textoPuntos;
    public GameObject punto;

    // Use this for initialization
    void Start () {
        actualizarPuntos();
        puntos = 0;
    }

    private void Awake()
    {
        puntos = 0;
    }

    void actualizarPuntos()
    {
        textoPuntos.text = Puntos.puntos + "";
    }

    public void sumarPunto()
    {
        Puntos.puntos++;
        actualizarPuntos();
    }

    public void visible()
    {
        punto.SetActive(true);
    }
    

}
