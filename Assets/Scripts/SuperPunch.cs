using UnityEngine;

public class SuperPunch : MonoBehaviour
{
    Rigidbody target;
    public Rigidbody ball;
    public GameObject ballCapsule;
    float punchForce;
    public float punchCoefficient = 1;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            target = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 collisionDirection = collision.contacts[0].normal; 
            target.AddForce(-collisionDirection * punchForce, ForceMode.Impulse);
        }
    }
    void Update()
    {
        punchForce = punchCoefficient* ball.linearVelocity.magnitude;
        Debug.Log("PunchForce = "+punchForce);
    }
}


    