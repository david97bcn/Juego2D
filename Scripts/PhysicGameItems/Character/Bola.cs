using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System;

public class Bola : MonoBehaviour {

    public Rigidbody2D rb;
    
    public float speed;
    public float maxSpeed;
    public float minSpeed;

    public float rotationSpeed;
    public float maxRotation;

    public float gravityForce;
    public float waitGravityTime;
    private float timeGravityFinish;
    private float timeGravityStart;
    public float maxGravity;
    public float normalGravtity;
    public float multSpeed;

    private float timeAirStart;
    private float timeAirFinish;
    public float waitAirTime;

    public Puntos puntos;
    public HideMenu hideMenu;
    //public RetryMenu retry;
    public RetryGestion retry;
    private bool startCount;
    private bool haPulsado;

    public bool haEmpezado;
    private bool isGrounded;
    private bool isChecked;
    public bool gOver;
    public int pauseScene;
    private int multVel;

    GameObject terrainAbove, terrainPrevious;
    private bool canClick;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 0;
        multSpeed = 0;
        timeAirFinish = 0;
        timeAirStart = 0;
        waitAirTime = 0;
        haEmpezado = false;
        timeGravityStart = 0;
        timeGravityFinish = 0;
        gOver = false;
        pauseScene = 1;
        multVel = 1;
        canClick = true;
        isGrounded = false;
        isChecked = false;
        haPulsado = false;
        startCount = false;
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {

        checkSpeedVariables();
        if (haEmpezado && !gOver)
        {
            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
            }
            else
            {
                rb.AddForce(new Vector2(speed, 0f), ForceMode2D.Force);
            }
        }

        if (rb.angularVelocity < maxRotation && !gOver)
        {
            rb.angularVelocity = maxRotation;
        }
        else
        {
            rb.AddTorque(-rotationSpeed);
        }
        // ScrollFront.current.Go(rb.velocity.x);

    }

    private void checkForceVariables()
    {
        if (Puntos.puntos < 15)
        {
            maxGravity = 10;
            multSpeed = 1.5f;
            waitAirTime = 0.6f;
            multVel = 1;
        }
        else 
        if (Puntos.puntos >= 15 && Puntos.puntos < 30)
        {
            maxGravity = 15;
            multSpeed = 2f;
            waitAirTime = 0.5f;
            multVel = 2;
        }
        else if (Puntos.puntos >= 30 && Puntos.puntos < 45)
        {
            maxGravity = 20;
            multSpeed = 2.5f;
            waitAirTime = 0.4f;
            multVel = 3;
        }
        else if (Puntos.puntos >= 45 && Puntos.puntos < 60)
        {
            maxGravity = 25;
            multSpeed = 2.5f;
            waitAirTime = 0.4f;
            multVel = 4;
        }
        else if (Puntos.puntos >= 60)
        {
            maxGravity = 30;
            multSpeed = 3f;
            waitAirTime = 0.4f;
            multVel = 5;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !haEmpezado && !gOver)
        {
            haEmpezado = true;
            timeGravityStart = Time.time;
            timeGravityFinish = timeGravityStart + waitGravityTime;
            hideMenu.hideMenu();
            puntos.visible();
            startCount = true;
            haPulsado = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && haEmpezado && !haPulsado && isGrounded && !gOver)
        {
            haPulsado = true;
            puntos.sumarPunto();
            timeGravityStart = Time.time;
            timeGravityFinish = timeGravityStart + waitGravityTime;
            if (!canClick)
            {
                //gOver = true;
            }
        }

        if (Time.time < timeGravityFinish && Time.time > timeGravityStart && !gOver)
        {
            checkForceVariables();
            rb.gravityScale = maxGravity;
            rb.AddForce(new Vector2(speed * multSpeed, 0f), ForceMode2D.Force);
        }
        else
        {
            haPulsado = false;
            rb.gravityScale = normalGravtity;
            timeGravityStart = 0;
            //timeGravityFinish = 0;
        }
        

    }
    private void checkSpeedVariables()
    {
        if (Puntos.puntos < 15)
        {
            maxSpeed = 15;
            speed = 10;
            maxRotation = -1000;
            rotationSpeed = 5;
        }
        else if (Puntos.puntos >= 15 && Puntos.puntos < 30)
        {
            maxSpeed = 20;
            speed = 15;
            maxRotation = -1500;
            rotationSpeed = 7.5f;
        }

        else if (Puntos.puntos >= 30 && Puntos.puntos < 45)
        {
            maxSpeed = 25;
            speed = 20;
            maxRotation = -2000;
            rotationSpeed = 10f;
        }

        else if (Puntos.puntos >= 45 && Puntos.puntos < 60)
        {
            maxSpeed = 30;
            speed = 25;
            maxRotation = -2000;
            rotationSpeed = 10f;
        }

        else if (Puntos.puntos >= 60)
        {
            maxSpeed = 35;
            speed = 30;
            maxRotation = -2000;
            rotationSpeed = 10f;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Terrain"))
        {
            if (terrainPrevious != null)
            {
                terrainAbove = collision.gameObject;
                if (haPulsado && haEmpezado && terrainAbove.transform.rotation.z >= terrainPrevious.transform.rotation.z)
                {
                    gameOver();
                }
                else
                {
                    terrainPrevious = terrainAbove;
                }
            }
            else
            {
                terrainPrevious = collision.gameObject;
            }
        }
    }
    */

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Terrain") || collision.gameObject.tag.Equals("TerrainInitial"))
        {
            //Terreno terrainAbove = collision.gameObject.GetComponent<Terreno>();
            //terrainAbove = collision.gameObject;
            //canClick = terrainAbove.GetComponentInChildren<Terreno>().canClick();

            isGrounded = true;
            if (isChecked == false && Time.time > timeAirFinish && haEmpezado == true && timeAirFinish != 0)
            {
                gameOver();
                //Time.timeScale = 0;
            }else
            {
                isChecked = true;
            }
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Terrain") || collision.gameObject.tag.Equals("TerrainInitial"))
        {
            isGrounded = false;
            timeAirStart = Time.time;
            timeAirFinish = timeAirStart + waitAirTime;
            isChecked = false;
        }
    }

    void gameOver()
    {
        gOver = true;
        isChecked = true;
        pauseScene = 0;
        retry.setVisible();
        puntos.GetComponent<Puntos>().punto.GetComponent<Punctuation>().rePosition();
    }

    public int getPauseScene()
    {
        return pauseScene;
    }

    public int getMultSpeed()
    {
        return multVel;
    }
    

}
