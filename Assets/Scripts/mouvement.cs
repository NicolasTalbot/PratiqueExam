using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour {
    private Rigidbody planeRigidBody;
    [SerializeField] float forward = 3;
    private ParticleSystem smoke;
    // Use this for initialization
    void Start() {
        planeRigidBody = GetComponent<Rigidbody>();
        smoke = GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Jump")>0)
        {
            planeRigidBody.AddRelativeForce(new Vector3(0, 0, forward)*Time.deltaTime*500);
        }
        if(planeRigidBody.velocity.z >0)
        {
            smoke.Play();
        }
        else
        {
            smoke.Stop();
        }
	}

    public Vector3 getSpeed()
    {
        return planeRigidBody.velocity;
    }
}
