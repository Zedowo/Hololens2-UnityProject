using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPrint : MonoBehaviour
{
    public float temp = 115;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void RotateByDegrees(float degree)
    {
        degree = degree * temp;
        degree = degree / 2;
        degree = degree * -1;
        Vector3 rotationToAdd = new Vector3(0, degree, 0);
        //transform.rotate = rotationToAdd;
        transform.localRotation = Quaternion.Euler(rotationToAdd);
    }

    // Update is called once per frame
    void Update()
    {


    }
}