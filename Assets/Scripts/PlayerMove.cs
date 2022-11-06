using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    public float speed;
    public float gravity;
    private Vector3 direction;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        direction = new Vector3(moveX, 0, moveZ);
        direction = transform.TransformDirection(direction);
        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime * speed);
    }
}
