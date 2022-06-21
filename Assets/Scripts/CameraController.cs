using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Ball;
    private Vector3 _offset;

    // Start is called before the first frame update
   private void Start()
    {
        _offset = transform.position - Ball.transform.position;
    }

    // Update is called once per frame
   private void LateUpdate()
    {
        transform.position = Ball.transform.position + _offset;
    }
}
