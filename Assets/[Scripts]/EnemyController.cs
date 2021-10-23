//T163-Game Programming
//GAME2014-F2021-Midterm-Phu-Pham
//Name: Phu Pham
//ID: 101250748
//Date last modified: Oct-23-2021
//File name: EnemyController.cs
//Program Desc: Midterm Submission
//Revision History: Changed vertical identifiers and methods to horizontal orientation, rotated enemy and changed bounds







using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check top boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
