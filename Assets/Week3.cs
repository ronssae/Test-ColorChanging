using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3_Rotation : MonoBehaviour
{
    public Quaternion CurrentRotation;
    public Vector3 currentEulerangles;
    float x, y, z;
    public float RotationSpeed;
    public Transform Target_A;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.Euler(90,90,90);
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        //RotationInputs();
        QuaternionRotateTowards();
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 30;
        //Use the Euler angles to show the euler angles of the transform rotation
        GUI.Label(new Rect(10, 0, 0, 0),
            "Rotating on X" + x + "Y" + y + "Z" + z, style);
        //Outputs the Quaternion.euler angle values
        GUI.Label(new Rect(10, 25, 0, 0),
            "Current Euler Angles" + currentEulerangles, style);
        //Outputs the transform.eulerAngles of the GameObject
        GUI.Label(new Rect(10, 50, 0, 0),
            "Game Object World Euler Angles" + transform.eulerAngles, style);
    }
    void RotationInputs()
    {
        if (Input.GetKeyDown(KeyCode.X)) { x = 1 - x; }
        if (Input.GetKeyDown(KeyCode.Y)) { y = 1 - y; }
        if (Input.GetKeyDown(KeyCode.Z)) { z = 1 - z; }

        currentEulerangles += new Vector3(x, y, z) * Time.deltaTime * RotationSpeed;
        CurrentRotation.eulerAngles = currentEulerangles;
        transform.rotation = CurrentRotation;
    }

    void QuaternionRotateTowards()
    {
        var step = RotationSpeed * Time.time;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Target_A.rotation,step);
    }
}
