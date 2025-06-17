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
        
            //IF _characterController isGrounded THEN
            if (_characterController.isGrounded)
            {
                // IF INPUT LeftShift is Pressed THEN
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    // SET _movementSpeed to _SprintSpeed
                    _movementSpeed = _sprintSpeed;
                }
                // ELSE IF INPUT LeftControl is pressed THEN
                else if (Input.GetKey(KeyCode.LeftControl))
                {
                    // SET _movementSpeed to _crouchSpeed
                    _movementSpeed = _crouchSpeed;
                }
                // ELSE
                else
                {
                    // SET _movementSpeed to _walkSpeed
                    _movementSpeed = _walkSpeed;
                }

                //ENDIF

                // SET _movementDirection to both horizontal vertical INPUT
                _movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                // SET _movementDirection MULTIPLIED by _movementSpeed
                _movementDirection *= _movementSpeed;
                // SET _movementDirection TransformDirection
                _movementDirection = transform.TransformDirection(_movementDirection);

                // IF INPUT space is pressed THEN
                if (Input.GetButton("Jump"))
                {
                    // SET _movement.y to _jumpspeed
                    _movementDirection.y = _jumpSpeed;
                }
                // ENDIF
            }
            //ENDIF

            // SET _movementDirection.y by _gravity
            _movementDirection.y -= _gravity * Time.deltaTime;
            // SET _characterController.Move by _movementDirection
            _characterController.Move(_movementDirection * Time.deltaTime);



        
    }
        

}
