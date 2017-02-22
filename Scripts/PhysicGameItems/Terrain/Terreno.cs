using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : MonoBehaviour {

    private bool haSalido = false;
    public Transform[] vTerrenos;
    private List<Transform> vInstances = new List<Transform>();
    public Transform[] vPuntos;
    private List<Transform> vInstancesPuntos = new List<Transform>();



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag.Equals("TerrainGenerator"))
        {
            if (haSalido == false)
            {
                int randNumb = Random.Range(1, 5);

                var terrenoContinuacion = vTerrenos[Random.Range(0, vTerrenos.Length)];
                var instance = Instantiate(terrenoContinuacion) as Transform;
                vInstances.Add(instance);
                

                if (transform.rotation.eulerAngles.z > 27 && transform.rotation.eulerAngles.z < 33)
                {
                    if (instance.transform.rotation.eulerAngles.z > 27 && instance.transform.rotation.eulerAngles.z < 33)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.27f, transform.position.y + 7.67f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 12 && instance.transform.rotation.eulerAngles.z < 18)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.9f, transform.position.y + 5.75f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > -3 && instance.transform.rotation.eulerAngles.z < 3)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14f, transform.position.y + 3.75f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 342 && instance.transform.rotation.eulerAngles.z < 348)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.6f, transform.position.y + 1.8f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 327 && instance.transform.rotation.eulerAngles.z < 333)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 12.5f, transform.position.y + 0f, 0);
                    }
                    instance.gameObject.SetActive(true);
                }


                if (transform.rotation.eulerAngles.z > 12 && transform.rotation.eulerAngles.z < 18)
                {
                    if (instance.transform.rotation.eulerAngles.z > 27 && instance.transform.rotation.eulerAngles.z < 33)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.9f, transform.position.y + 5.76f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 12 && instance.transform.rotation.eulerAngles.z < 18)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.83f, transform.position.y + 3.97f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > -3 && instance.transform.rotation.eulerAngles.z < 3)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.9f, transform.position.y + 1.94f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 342 && instance.transform.rotation.eulerAngles.z < 348)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.5f, transform.position.y + 0f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 327 && instance.transform.rotation.eulerAngles.z < 333)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.55f, transform.position.y - 1.8f, 0);
                    }
                    instance.gameObject.SetActive(true);
                }

                if (transform.rotation.eulerAngles.z > -3 && transform.rotation.eulerAngles.z < 3)
                {
                    if (instance.transform.rotation.eulerAngles.z > 27 && instance.transform.rotation.eulerAngles.z < 33)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14f, transform.position.y + 3.75f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 12 && instance.transform.rotation.eulerAngles.z < 18)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.93f, transform.position.y + 1.97f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > -3 && instance.transform.rotation.eulerAngles.z < 3)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 15.3f, transform.position.y, 0f);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 342 && instance.transform.rotation.eulerAngles.z < 348)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.93f, transform.position.y - 1.97f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 327 && instance.transform.rotation.eulerAngles.z < 333)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14f, transform.position.y - 3.75f, 0);
                    }
                    instance.gameObject.SetActive(true);
                }

                if (transform.rotation.eulerAngles.z > 342 && transform.rotation.eulerAngles.z < 348)
                {
                    if (instance.transform.rotation.eulerAngles.z > 27 && instance.transform.rotation.eulerAngles.z < 33)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.55f, transform.position.y + 1.79f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 12 && instance.transform.rotation.eulerAngles.z < 18)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.5f, transform.position.y + 0f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > -3 && instance.transform.rotation.eulerAngles.z < 3)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.92f, transform.position.y - 1.96f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 342 && instance.transform.rotation.eulerAngles.z < 348)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14.8f, transform.position.y - 3.965f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 327 && instance.transform.rotation.eulerAngles.z < 333)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.9f, transform.position.y - 5.76f, 0);
                    }
                    instance.gameObject.SetActive(true);
                }

                if (transform.rotation.eulerAngles.z > 327 && transform.rotation.eulerAngles.z < 333)
                {
                    if (instance.transform.rotation.eulerAngles.z > 27 && instance.transform.rotation.eulerAngles.z < 33)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 12.66f, transform.position.y - 0f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 12 && instance.transform.rotation.eulerAngles.z < 18)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.58f, transform.position.y - 1.79f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > -3 && instance.transform.rotation.eulerAngles.z < 3)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 14f, transform.position.y - 3.75f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 342 && instance.transform.rotation.eulerAngles.z < 348)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.9f, transform.position.y - 5.76f, 0);
                    }

                    if (instance.transform.rotation.eulerAngles.z > 327 && instance.transform.rotation.eulerAngles.z < 333)
                    {
                        instance.localPosition = new Vector3(transform.position.x + 13.29f, transform.position.y - 7.675f, 0);
                    }
                    instance.gameObject.SetActive(true);
                }
                
                if (randNumb == 3)
                {
                    //Debug.Log("Rand: " + randNumb);
                    var punto = vPuntos[0];
                    var instPunto = Instantiate(punto) as Transform;
                    vInstancesPuntos.Add(instPunto);
                    instPunto.localPosition = new Vector3(transform.position.x, transform.position.y + 2f, 0);
                    instPunto.gameObject.SetActive(true);
                }
                
                haSalido = true;
            }

        }

    }


    public bool canClick()
    {
        if (vInstances[0].rotation.z >= transform.rotation.z)
        {
            return false;
        }
        return true;
    }
    

}
