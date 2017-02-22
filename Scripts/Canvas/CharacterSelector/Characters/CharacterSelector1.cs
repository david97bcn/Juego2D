using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector1 : MonoBehaviour {
    
    private Vector2 pos;

    // Use this for initialization
    void Start () {
        pos.x = (Screen.width / 16);
        pos.y = Screen.height - (Screen.height / 8);
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width / 2.5f, (Screen.height / 6));
        transform.position = pos;
    }

}
