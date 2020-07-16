using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1000f * Time.deltaTime));
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1000f * Time.deltaTime));
        }
    }

    public void left()
    {
        // gameObject.transform.Translate(0, 0, -50f * Time.deltaTime);
        // gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1000f * Time.deltaTime));
        transform.position += Vector3.left * 1000f * Time.deltaTime;
    }

    public void right()
    {
        // gameObject.transform.Translate(0, 0, 50f * Time.deltaTime);
        // gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1000f * Time.deltaTime));
        transform.position += Vector3.right * 1000f * Time.deltaTime;
    }
}
