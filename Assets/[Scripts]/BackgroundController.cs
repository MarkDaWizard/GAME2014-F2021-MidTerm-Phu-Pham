//T163-Game Programming
//GAME2014-F2021-Midterm-Phu-Pham
//Name: Phu Pham
//ID: 101250748
//Date last modified: Oct-23-2021
//File name: BackgroundController.cs
//Program Desc: Midterm Submission
//Revision History: Changed vertical identifiers and methods to horizontal orientation
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f ) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is further than the left side of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
