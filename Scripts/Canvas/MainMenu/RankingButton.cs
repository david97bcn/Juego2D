using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingButton : MonoBehaviour {
    
    private Vector3 sizeBola;
    private Vector2 position;

    // Use this for initialization
    void Start()
    {
        position.x = (Screen.width / 1.75f);
        position.y = (Screen.height / 4) / 1.5f;
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width / 8, Screen.width / 8);
        transform.position = position;
    }
    
}
