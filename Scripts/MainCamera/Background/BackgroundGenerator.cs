using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

    public GameObject[] vBackgrounds;

    void Start () {
        GameObject background = vBackgrounds[Random.Range(0, vBackgrounds.Length)];
        background.SetActive(true);
    }
}
