using System;
using UnityEngine;
using TMPro;
public class Buffs_P2 : MonoBehaviour
{
    public TextMeshProUGUI Boost_P2;

    public int boostCount_P2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostCount_P2 = 0;
        Boost_P2.text = "BOOST: "+boostCount_P2;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Boost"))
        {
            Destroy(other.gameObject);
            boostCount_P2++;
        }
        else if (other.gameObject.CompareTag("Speed"))
        {
            Destroy(other.gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Boost_P2.text = "BOOST: "+boostCount_P2;
    }
}