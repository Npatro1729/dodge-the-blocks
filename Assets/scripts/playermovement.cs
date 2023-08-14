using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    public float mapwidth = 5f;

    void FixedUpdate()
    {
        
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x , -mapwidth , mapwidth);
        rb.MovePosition(newPosition);
        
    }
    void OnCollisionEnter2D(){
        FindObjectOfType<Gamemanager>().endGame();
    }
}
