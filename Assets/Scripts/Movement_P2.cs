using UnityEngine;
using TMPro;
public class Movement_P2 : MonoBehaviour
{
    public float movementForce = 10;
    public float rotationSpeed = 300f;
    public int strikeForce = 50;

    public Rigidbody rb;
    public GameObject cam;
    public TextMeshProUGUI speedometer;
    public TextMeshProUGUI boost;
    private Buffs_P2 buffs;
    void Start()
    {
        buffs = GetComponent<Buffs_P2>();
    }

    // Update is called once per frame

    void Update()
    {
        speedometer.text="SPEED: "+(int)(rb.linearVelocity.magnitude*7)+"km/h";
        if (Input.GetKey(KeyCode.UpArrow))//Kameranın +z yönünde kuvvet uygulanmalı
        {
            rb.AddForce(cam.transform.forward * movementForce, ForceMode.Force);
            Debug.Log("Tus Girdsisi");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-cam.transform.forward * movementForce, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-cam.transform.right * movementForce, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(cam.transform.right * movementForce, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.Keypad0)&&(buffs.boostCount_P2 !=0))
        {
            buffs.boostCount_P2--;
            rb.AddForce(cam.transform.up * movementForce, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            cam.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Keypad3))
        {
            cam.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2)&&(buffs.boostCount_P2 !=0))
        {
            buffs.boostCount_P2--;
            rb.AddForce(cam.transform.forward * strikeForce, ForceMode.Impulse);
           
           
        }
    }
}
