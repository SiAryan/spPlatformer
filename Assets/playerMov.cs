using UnityEngine;

public class playerMov : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewasForce = 500f;
    public bool canJump = false;
    public int counter = 0;
    public bool cc = false;

    // Update is called once per frame

        /*
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*sidewasForce, 0.0f, moveVertical*forwardForce);

        rb.AddForce(movement);
    }
    */



   
void FixedUpdate()
{
    if (Input.GetKey("a"))
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
    if (Input.GetKey("w"))
    {
        rb.AddForce(sidewasForce * Time.deltaTime, 0, 0);
    }
    if (Input.GetKey("s"))
    {
        rb.AddForce(-1 * sidewasForce * Time.deltaTime, 0, 0);
    }
    if (Input.GetKey("d"))
    {
        rb.AddForce(0, 0, -1 * forwardForce * Time.deltaTime);
    }

    if (canJump)
    {
        canJump = false;
        rb.AddForce(0, 12, 0, ForceMode.Impulse);
    }
    if (Input.GetKeyUp("space") && !cc)
    {
        canJump = true;
        cc = true;
    }

    if (cc)
    {
        counter++;
    }
    if (counter == 100) {

        cc = false;
        counter = 0;
    }


}



}
