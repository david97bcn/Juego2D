using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punctuation : MonoBehaviour {
    
    public GameObject punctImg;
    private Vector3 sizeBola;
    private Vector2 position;
    Text t;

    // Use this for initialization
    void Start()
    {
        t = GetComponent<Text>();
        position.x = (Screen.width / 14);
        position.y = Screen.height - (Screen.width / 16);
        transform.position = position;
        t.fontSize = Screen.width / 6;
    }

    public void rePosition()
    {
        t.fontSize = Screen.width / 4;
        t.transform.position = new Vector3((Screen.width / 2), (Screen.height / 1.75f));
    }

}
