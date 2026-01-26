using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 offset = new Vector3(0, 3, -5);
    [SerializeField] private float _sensX = 250f;
    [SerializeField] private float _sensY = 120f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


        Vector3 angles = transform.eulerAngles;
        yRotation = angles.y;
        xRotation = angles.x;
    }

    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * _sensX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensY * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -35f, 60f);


        Quaternion rotation = Quaternion.Euler(xRotation, yRotation, 0);


        transform.position = _player.position + rotation * offset;


        transform.LookAt(_player.position + Vector3.up * 1.5f);
    }
}
