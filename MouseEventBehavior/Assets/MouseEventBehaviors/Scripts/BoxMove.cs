using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float Speed;
    public Vector3 MoveSpeed;
    public Vector3 RotateSpeed;

    private void Update()
    {
        MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
        MoveSpeed.z = Speed*Input.GetAxis("Vertical");
        
        transform.Translate(MoveSpeed);
        transform.Rotate(RotateSpeed);

    }
}
