using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{
    [SerializeField] private GameObject Panel_GANASTE;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Panel_GANASTE.SetActive(true);
        }
    }
}