using System;
using UnityEngine;
using TMPro;
public class Buffs_P1 : MonoBehaviour
{
    public TextMeshProUGUI Boost_P1;
    private Movement movement_P1;
    public int boostCount_P1;

    public int speedDuration=6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostCount_P1 = 0;
        Boost_P1.text = "BOOST: "+boostCount_P1;
        movement_P1 = GetComponent<Movement>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Boost"))
        {
            Destroy(other.gameObject);
            boostCount_P1++;
        }
        else if (other.gameObject.CompareTag("Speed"))
        {
            Destroy(other.gameObject);
            movement_P1.movementForce *= 2;
            Invoke(nameof(SetSpeedToOriginal), speedDuration);
        }
    }

    void SetSpeedToOriginal()
    {
        movement_P1.movementForce /= 2;
    }
    // Update is called once per frame
    void Update()
    {
        Boost_P1.text = "BOOST: "+boostCount_P1;
    }
}
