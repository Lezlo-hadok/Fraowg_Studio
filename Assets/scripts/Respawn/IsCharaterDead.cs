using UnityEngine;

public class IsCharaterDead : MonoBehaviour
{
    public  static bool isAlive;
    internal static object isCharaterDead;
    public CharacterController _characterController;
    private void Start()
    {
        isAlive = true;
        CharacterDied();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DeathBubble")
        {
            isAlive=false;    
        }
    }
    void CharacterDied()
    {
        CharacterController controller = _characterController;
        controller.enabled = isAlive;
    }
}
