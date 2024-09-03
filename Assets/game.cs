using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 1000f;
    public float SideForce = 500f;
    public Vector3 InitialPosition = new Vector3(0, 6, -33.7f);

 // Add a semicolon here

    void Start()
    {        
        this.name = "BBL";
        rb.useGravity = true;
        rb.AddForce(0, -50, 5000 * Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(2000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-2000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -2000 * Time.deltaTime);
            Score.scoreCount -= 1;
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 2000 * Time.deltaTime);
            Score.scoreCount += 1;
        }
        if (Input.GetKey("p"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey("l"))
        {
            SceneManager.LoadScene(0);
        }

    }

    public void Reset()
    {
        this.transform.position = InitialPosition;
    }
}
