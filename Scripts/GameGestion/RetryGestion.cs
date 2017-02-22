using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryGestion : MonoBehaviour {

    public GameObject retry;

	public void setVisible()
    {
        retry.gameObject.SetActive(true);
    }

}
