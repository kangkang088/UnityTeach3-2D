using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson39_Exercises : MonoBehaviour
{
    public Transform IKPoint;
    // Start is called before the first frame update
    private float z;
    private Vector3 mousePos;
    void Start()
    {
        z = Camera.main.WorldToScreenPoint(IKPoint.position).z;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = z;
            IKPoint.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}
