using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Variables used throughout the code
    [Header("Moving Player Direction")]
    // Stores the player's movement direction as a 3D vector (x, y, z)
    [SerializeField] Vector3 _movementDirection = Vector3.zero;
    // A reference to the CharacterController component, which handles player movement
    [SerializeField] CharacterController _characterController;
    [Header("Speed that the player moves")]
    // Stores the current movement speed of the player
    [SerializeField] float _movementSpeed;
    // Different movement speeds for walking, sprinting, and crouching
    [SerializeField] float _walkSpeed = 5, _sprintSpeed = 10, _crouchSpeed = 2.5f;
    // Speed applied when the player jumps
    [SerializeField] float _jumpSpeed = 10;
    // Strength of gravity applied to the player to keep them grounded
    [SerializeField] float _gravity = 20;
    void Start()
    {
        //references the character controller 
        _characterController = this.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
    }
    
}