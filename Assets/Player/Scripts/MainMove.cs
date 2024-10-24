using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMove : MonoBehaviour
{
    [SerializeField] private int _speed; 
    [SerializeField] private int _mouseSpeed = 5;

    private void FixedUpdate()
    {
        float maxRightPosition = 3.72f;
        float maxLeftPosition = -1.1f;
        float changePositionNumber = 0.1f;

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDirection = new Vector3(Input.GetAxis("Mouse X"), 0, 0);

            if (transform.position.x < maxRightPosition && transform.position.x > maxLeftPosition)
            {
                transform.Translate(mouseDirection * _mouseSpeed * Time.deltaTime);
            }
            else if (transform.position.x > maxRightPosition)
            {
                var playerPosition = transform.position;
                playerPosition.x -= changePositionNumber;
                transform.position = playerPosition;
            }
            else if (transform.position.x < maxLeftPosition)
            {
                var playerPosition = transform.position;
                playerPosition.x += changePositionNumber;
                transform.position = playerPosition;
            }
        }
    }
}
