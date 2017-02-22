using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {

    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        position.x = Screen.width - (Screen.width / 32);
        position.y = Screen.height - (Screen.width / 64);
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width / 8, Screen.width / 8);
        transform.position = position;
    }

}
