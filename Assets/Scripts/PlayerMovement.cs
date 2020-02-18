using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigigbody component called "rb".
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 600f;

    // We marked this as FixedUpdate because we are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
