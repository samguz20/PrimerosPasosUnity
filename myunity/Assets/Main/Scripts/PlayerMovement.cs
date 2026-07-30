using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Variables
    [SerializeField]
   private int _edad = 17;
   private float _velocidad = 15.5f;
   public string nombre = "Samuel";
   public bool isJumping = false;

    public float fuerza = 500f;

    [SerializeField] private Rigidbody2D _rigibody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigibody2D.AddForce(Vector2.right * fuerza);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
