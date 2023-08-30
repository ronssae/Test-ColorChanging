using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Emovement
{
    Forward, 
    Backward, 
    Left, 
    Right
}
public class Vector3_Examples : MonoBehaviour
{

    public float MoveSpeed;
    public Emovement movementType;
    public Transform point_A, point_B;
    public float RangeValue = 1.0f;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovement.Forward:
        //        MoveForward();
        //        break;
        //    case Emovement.Backward:
        //        MoveBackward();
        //        break;
        //    case Emovement.Left:
        //        MoveLeft();
        //        break;
        //    case Emovement.Right:
        //        MoveRight();
        //        break;
        //    default:
        //        break;
        //}
        distance = Vector3.Distance(transform.position,point_B.position);
        if (distance <= RangeValue)
        {
            Debug.Log("Don't touch me.");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, RangeValue);
    }

    public void MoveForward()
    {
        transform .position = Vector3.forward * MoveSpeed * Time.time;
    }
    public void MoveBackward()
    {
        transform.position = Vector3.back * MoveSpeed * Time.time;
    }
    public void MoveLeft()
    {
        transform.position = Vector3.left * MoveSpeed * Time.time;
    }
    public void MoveRight()
    {
        transform.position = Vector3.right * MoveSpeed * Time.time;
    }
}
