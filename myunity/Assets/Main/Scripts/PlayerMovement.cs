using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Variables
    [SerializeField]
    public float altura = 1.82f;
    public int edad = 17;
    public string nombre = "Samuel";
    public bool puedeVotar = true;


    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform;
    //crear una variable de tipo transform

    private void Start()
    {
        Debug.Log("Hola: " + nombre + "tu edad es: " + edad + "tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.yellow;
        //llamo mi variable de tipo traansform y le asigno un valor en x de 10
        transform.position = new Vector3(5f, 0f, 0f);
    }

    private void Update()
    {
    }
}


     
