using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Transform car;
    public float speed;
    public float speedForward;

    void Update()
    {
        car.position = transform.position + new Vector3(0, 0, speedForward * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.deltaPosition.x > 0f)
            {
                Touch touch1 = Input.GetTouch(0);
                car.position = transform.position + new Vector3(touch1.position.x * speed * Time.deltaTime, 0, 0);
            }
            if (touch.deltaPosition.x < 0f)
            {
                Touch touch1 = Input.GetTouch(0);
                car.position = transform.position + new Vector3(-touch1.position.x * speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
