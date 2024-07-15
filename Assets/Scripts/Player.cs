using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int power;
    public string n;
    private Rigidbody2D myBody;
    private BoxCollider2D myColldier;
    private Transform myTransform;
    public Player(String name, int power, int health) {
        this.name = name;
        this.power = power;
        this.health = health;
    }

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
        //myTransform.position = new Vector3(10,20,30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

} // class
