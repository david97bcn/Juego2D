using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour {

    public GameObject characterSelector;
    public Button closeButton;

    // Use this for initialization
    void Start()
    {
        Button closebtn = closeButton.GetComponent<Button>();
        closebtn.onClick.AddListener(closeClick);
    }

    void closeClick()
    {
        characterSelector.SetActive(false);
        Debug.Log("Cerrar");
    }
}
