using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float TOP_BOUND = 30.0f;
    private const float BOTTOM_BOUND = -10.0f;
    void Update()
    {
        if (transform.position.z < TOP_BOUND && transform.position.z > BOTTOM_BOUND) return;

        Destroy(gameObject);
    }
}
