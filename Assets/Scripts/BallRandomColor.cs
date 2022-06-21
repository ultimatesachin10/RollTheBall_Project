using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRandomColor : MonoBehaviour
{
    public GameObject Ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickableItems")
        {
            ChangeColor();
        }
    }
    private void ChangeColor()
    {
        Ball.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}
