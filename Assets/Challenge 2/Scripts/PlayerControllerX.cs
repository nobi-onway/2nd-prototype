using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private const float COOL_DOWN_TIME = 1.5f;

    private float countDown = 0;
    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && countDown <= 0)
        {
            countDown = COOL_DOWN_TIME;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
