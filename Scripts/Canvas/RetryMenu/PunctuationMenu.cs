using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunctuationMenu : MonoBehaviour {
    
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        position.x = (Screen.width / 2);
        position.y = (Screen.height / 1.75f);
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width / 4, Screen.width / 4);
        transform.position = position;
    }

}
