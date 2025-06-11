using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [Header("Sensitivity Settings")]
    // Controls how fast the camera rotates
    public float sensitivity = 8;

    [Header("Rotation Clamping")]
    // Limits vertical rotation 
    [SerializeField] Vector2 _verticalRotationClamp = new Vector2(-60, 60);

    [Header("Camera Setup")]
    // Referance to the player object (for horizontal rotation)
    [SerializeField] Transform _player;
    // reference to the camera object (for vertical rotation)
    [SerializeField] Transform _camera;
    // Stores the temporary vertical rotation
    [SerializeField] float _tempRotation;
    // Final vertical rotation value
    [SerializeField] float _verticalRotation;

    void Update()
    {
        // READ mouse x input ROTATE player on Y-axis using (Mouse X * sensitivity) 
        _player.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        // READ mouse y inpute ADD (Mouse Y * sensitivity) to temporary rotation value 
        _tempRotation += Input.GetAxis("Mouse Y") * sensitivity;
        // CLAMP temporary rotation between min and max rotation limits 
        _tempRotation = Mathf.Clamp(_tempRotation, _verticalRotationClamp.x, _verticalRotationClamp.y);

        // APPLY vertical rotation to the camera's local X - axis
        _camera.localEulerAngles = new Vector3(_verticalRotation, 0, 0);
    }
}
