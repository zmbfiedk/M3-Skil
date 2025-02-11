using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer; 
    
    public bool state = false;

    private void OnMouseUp()
        {
         state = !state;
        }

    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.color = Color.yellow;
    }

    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color= Color.red;
        }
    }

    
}
