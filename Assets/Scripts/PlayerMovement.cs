using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //Reference to Player Rigidbody
    public float ForwardForce = 2000f;
    public float SidewayForce = 500f;

    // FixedUpdate For Aplying Physics To Object Over Time
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime); //Add ForwardForce 2000 To z Axis.

        if (Input.GetKey("d")) 
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
