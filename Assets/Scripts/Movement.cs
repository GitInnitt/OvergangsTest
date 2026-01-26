using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _turnSpeed = 100f;
    [SerializeField] private float _acceleration = 0f;

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");


        _speed += moveInput * _acceleration * Time.deltaTime;
        _speed = Mathf.Clamp(_speed, -20f, 40f);


        transform.Translate(Vector3.forward * _speed * Time.deltaTime);


        transform.Rotate(Vector3.up * turnInput * _turnSpeed * Time.deltaTime);
    }
}