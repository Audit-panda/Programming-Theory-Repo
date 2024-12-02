using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected string shapeName { get; set; }
   
    [SerializeField] protected GameObject displayText;

    protected virtual void DisplayText()
    {
        displayText.GetComponent<TMP_Text>().text = "My name:\n" + shapeName;
        
    }

}
