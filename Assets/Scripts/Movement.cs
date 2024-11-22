using UnityEngine;
using TMPro;
public class Movement : MonoBehaviour
{
    public float movementForce = 10;
    public float rotationSpeed = 300f;
    public int strikeForce = 15;

    public Rigidbody rb;
    public GameObject cam;
    public TextMeshProUGUI speedometer;
    public TextMeshProUGUI boost;
    private Buffs_P1 buffs;
    void Start()
    {
        buffs = GetComponent<Buffs_P1>();
    }

    // Update is called once per frame

    void Update()
    {   
        speedometer.text="SPEED: "+(int)(rb.linearVelocity.magnitude*7)+"km/h";
        if (Input.GetKey(KeyCode.W))//Kameranın +z yönünde kuvvet uygulanmalı
        {
            rb.AddForce(cam.transform.forward * movementForce, ForceMode.Force);
            Debug.Log("Tus Girdsisi");
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-cam.transform.forward * movementForce, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-cam.transform.right * movementForce, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(cam.transform.right * movementForce, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.Space)&&(buffs.boostCount_P1 !=0))
        {
            buffs.boostCount_P1--;
            rb.AddForce(cam.transform.up * movementForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.R))
        {
            cam.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            cam.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.T)&&(buffs.boostCount_P1 !=0))
        {
            buffs.boostCount_P1--;
            rb.AddForce(cam.transform.forward * strikeForce, ForceMode.Impulse);
           
           
        }
    }
}
