using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED = 20.0f;
    private const float xRange = 13.0f;
    [SerializeField] private GameObject _bullet;
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * SPEED * horizontalInput * Time.deltaTime);

        if (transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        if (transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(_bullet, transform.position, Quaternion.identity);
    }
}
