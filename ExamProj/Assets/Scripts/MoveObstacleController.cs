using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleController : MonoBehaviour
{
    public float moveY = 0f;
    public float moveX = 0f;
    public float moveZ = 0f;
    public float speed = 2.0f;

    private int target = 0;
    private Vector3[] positions = new Vector3[3];
    private Vector3 startPosition;
    void Start()
    {
        positions[0] = transform.position;
        positions[1] = positions[0] + new Vector3(moveX, moveY, moveZ);
        positions[2] = positions[0];
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (target < positions.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, positions[target], speed * Time.deltaTime);
            if (transform.position == positions[target])
            {
                target = (target + 1) % positions.Length;
            }
        }
    }
}
