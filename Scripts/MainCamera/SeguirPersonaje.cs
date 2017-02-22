using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour {

    private GameObject personaje;
    

    private void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Character");
    }

    private void Awake()
    {
        personaje = GameObject.FindGameObjectWithTag("Character");
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(personaje.transform.position.x+6, personaje.transform.position.y+3, personaje.transform.position.z-10);
	}
}
