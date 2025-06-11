using UnityEngine;

public class MouseLook : MonoBehaviour
{

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

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
