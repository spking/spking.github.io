using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    public float Force = 2000f;

    public float SideForce = 10000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime);
        }
        if (Input.GetKey("d")) 
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) 
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s")) 
        {
            rb.AddForce( 0, 0, -Force * Time.deltaTime);
        }
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
