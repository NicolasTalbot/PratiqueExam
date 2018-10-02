using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationElice : MonoBehaviour {
    [SerializeField] public float vitesseRotation;
    private mouvement avion;
    
    // Use this for initialization
    void Start () {
        avion = GetComponentInParent<mouvement>();
	}
	
	// Update is called once per frame
	void Update () {
       transform.Rotate(avion.getSpeed());
    }
}
