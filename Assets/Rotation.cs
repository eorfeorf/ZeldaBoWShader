using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rot = 0.05f;
    
    void Update()
    {
        this.transform.Rotate(0, rot, 0);
    }
}