using UnityEngine;

public class OrangeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidbody;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true || Input.GetKeyDown(KeyCode.Space)==true)
        {
            myRigidbody.linearVelocity = Vector2.up * 10;

        }
    }
}
