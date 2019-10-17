/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorResponse : MonoBehaviour
{
    protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Tower;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) OrbitTower(false);
        if (Input.GetKey(KeyCode.LeftArrow)) OrbitTower(true);
        if (Input.GetKey(KeyCode.UpArrow)) MoveInOrOut(false);
        if (Input.GetKey(KeyCode.DownArrow)) MoveInOrOut(true);
    }

    protected void OrbitTower(bool bLeft)
    {
        float step = fSpeed * Time.deltaTime;
        float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
        float fDistanceDegrees = (fSpeed / fOrbitCircumfrance) * 360;
        float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
        if (bLeft)
        {
            transform.RotateAround(Tower.transform.position, Vector3.up, -fDistanceRadians);
        }
        else
            transform.RotateAround(Tower.transform.position, Vector3.up, fDistanceRadians);
    }

    protected void MoveInOrOut(bool bOut)
    {
        if (bOut) transform.Translate(0, 0, -fSpeed, Space.Self);
        else
            transform.Translate(0, 0, fSpeed, Space.Self);
    }
}

*/
