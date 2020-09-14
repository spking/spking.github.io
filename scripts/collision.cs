using UnityEngine;

public class collision : MonoBehaviour
{
    public playermovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Obsacle"){
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
        }
    }

}
