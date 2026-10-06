using UnityEngine;
using UnityEngine.SceneManagement;

public class meta : MonoBehaviour
{
    [SerializeField] private GameObject _panelganaste;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _panelganaste.SetActive(true);
        }
    }

}