﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour {

    public GameObject menu;
    
    public void hideMenu()
    {
        menu.SetActive(false);
    }

}
