using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private CinemachineCamera _cinemachineCam;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _moveSpeed = 5f;
    private Vector2 _move;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnMove(InputValue value)
    {
        _move = value.Get<Vector2>();
    }
    private void Update()
    {
        _characterController.Move((GetForward() * _move.y + GetRight() * _move.x) * _moveSpeed * Time.deltaTime);   
    }
    private Vector3 GetForward()
    {
        Vector3 forward = _cinemachineCam.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }
    private Vector3 GetRight()
    {
        Vector3 right = _cinemachineCam.transform.right;
        right.y = 0;
        return right.normalized;
    }
}
