using UnityEngine;

public class IsCharaterDead : MonoBehaviour
{
    //is the charater alive 
    public  static bool isAlive;
    //name of script
    internal static object isCharaterDead;
    //character controler
    public CharacterController _characterController;
    //on start set alive to true and check if charater is dead
    private void Start()
    {
        isAlive = true;
        CharacterDied();
    }
    //is character in the death zone
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DeathBubble")
        {
            isAlive=false;    
        }
    }
    //turn off/on the charater controler
    void CharacterDied()
    {
        CharacterController controller = _characterController;
        controller.enabled = isAlive;
    }
}
