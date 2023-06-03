using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// demonstrates abstraction
public abstract class Box : MonoBehaviour
{
    // demonstrates encapsulation
    public bool PickedUp
    {
        get => _pickedUp;
        set
        {
            if (value == _pickedUp) return;
            _pickedUp = value;
            if (_pickedUp)
            {
                OnPickedUp();
            }
            else
            {
                OnDropped();
            }
        }
    }

    private bool _pickedUp; 
    
    public abstract void OnPickedUp();
    
    public abstract void OnDropped();

    public virtual void WhilePickedup()
    {
        
    }
    
    public void Update()
    {
        if (PickedUp)
        {
            WhilePickedup();
        }
    }
}
