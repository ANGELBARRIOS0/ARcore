using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private bool colorState = false;
    private Renderer colorCar;
    // Start is called before the first frame update
    void Start()
    {
        colorCar = GetComponent<Renderer>();
        colorState = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            changeColor();
        }
    }

    private void changeColor()
    {
        colorCar.material.SetColor("_Color", Color.blue);
        colorState = true;
    }
}
