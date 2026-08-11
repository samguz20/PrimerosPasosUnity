using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;
    private void OnTriggerEnter2D(Collider2D colission)
    {
        Debug.Log("Me tocaron!!");
    }
    private void OnTriggerExit2D(Collider2D colission)
    {
        Debug.Log("Me dejaron de tocar");
    }
}
