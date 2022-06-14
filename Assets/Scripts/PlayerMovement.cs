using Mirror;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _rotationAngle = 20f;

    private void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 movement = transform.forward * vertical * _speed * Time.deltaTime;
            Vector3 rotation = Vector3.up * horizontal * Time.deltaTime;
            
            transform.position += movement;
            transform.Rotate(Vector3.up, horizontal * _rotationAngle * Time.deltaTime);
        }
    }

    private void Update()
    {
        HandleMovement();
    }
}
