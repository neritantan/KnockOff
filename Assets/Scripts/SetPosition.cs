using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public Rigidbody rb_sphere;
    //public Rigidbody rb_capsule;
    public GameObject capsule;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        capsule.transform.position = new Vector3(rb_sphere.position.x, (rb_sphere.position.y +1), rb_sphere.position.z);
    }
}
