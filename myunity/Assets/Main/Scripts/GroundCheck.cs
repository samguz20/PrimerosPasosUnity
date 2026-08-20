using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGround;
    private void OnTriggerStay2D(Collider2D colission)
    {
       isGround = true;
        Debug.Log("Me tocaron!!");
    }
    private void OnTriggerExit2D(Collider2D colission)
    {
        isGround = false;
        Debug.Log("Me dejaron de tocar");
    }
}
