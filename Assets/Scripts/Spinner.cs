using UnityEngine;

public class Spinner : MonoBehaviour
{
    public GameObject table;
    public int speedCoefficent = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        table.transform.Rotate(Vector3.up * Time.deltaTime * 10f*speedCoefficent);
    }
}
