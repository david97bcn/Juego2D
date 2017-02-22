using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollFront : MonoBehaviour {

    public float iSpeed;
    private float speed;
    public static ScrollFront current;
    private MeshRenderer m;
    public Bola bola;
    private int pauseScene;

    float pos = 0;
    

    void Start () {
        current = this;
        m = current.gameObject.GetComponent<MeshRenderer>();
    }
	
    
	public void Update() {
        if (bola.getPauseScene() == 1)
        {

            switch (bola.getMultSpeed())
            {
                case 1:
                    speed = iSpeed * 1;
                    break;
                case 2:
                    speed = iSpeed * 1.2f;
                    break;
                case 3:
                    speed = iSpeed * 1.4f;
                    break;
                case 4:
                    speed = iSpeed * 1.6f;
                    break;
                case 5:
                    speed = iSpeed * 1.8f;
                    break;
            }
            
            pos += speed;
            if (pos > 1.0f)
            {
                pos -= 1.0f;
            }
            m.material.mainTextureOffset = new Vector2(pos, 0);

        }else
        {
            Time.timeScale = 0;
        }
	}
}
