using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour
{
    private static bool gano = false;

    public void Ganar()
    {
        gano = true;
        SceneManager.LoadScene(0);
    }
    public void CargarEscena(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
    public void ReiniciarElJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReanudarElJuego()
    {
        Time.timeScale = 1;
    }
    public void PausarElJuego()
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
