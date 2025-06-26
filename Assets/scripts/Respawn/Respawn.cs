using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint; // Assign this in the inspector
    private CharacterController _characterController;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Example: Respawn if falling too low
        if (transform.position.y < -10)
        {
            RespawnPlayer();
        }
        //if charater is dead by health or death bubble
        if (IsCharaterDead.isAlive == false)
        {
            RespawnPlayer();
            IsCharaterDead.isAlive = true;
        }
    }
    /// <summary>
    /// this checks to see if the player needs to be respawned
    /// </summary>
    public void RespawnPlayer()
    {
        if (_characterController != null)
        {
            _characterController.enabled = false; // Disable to prevent issues
        }

        transform.position = spawnPoint.position;

        if (_characterController != null)
        {
            _characterController.enabled = true; // Re-enable after teleport
        }
    }
}
