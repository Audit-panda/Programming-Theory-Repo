using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Entity : Shape // INHERITANCE
{
    public string myName;
    public Color myColor;
    // POLYMORPHISM
    protected override void DisplayText()
    {
        shapeName = myName;       
        base.DisplayText();
                
    }

    private void Start()
    {
        DisplayText();
        GetComponent<Renderer>().material.color = myColor;
    }

    private void Update()
    {
        // ABSTRACTION
        Rotate();
        Move();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, 90f * Time.deltaTime);
    }

    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

}
