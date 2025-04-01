using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public int cenaAtual;

    private void Start()
    {
        cenaAtual = SceneManager.GetActiveScene().buildIndex;
    }

    #region Menu inicial
    public void Iniciar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Fase1()
    {
        SceneManager.LoadScene("Fase 1");
    }
    public void Fase2()
    {
        SceneManager.LoadScene("Fase 2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("Fase 3");
    }

    public void FecharJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
    #endregion

    #region In Game
    public void Reiniciar()
    {
        SceneManager.LoadScene(cenaAtual);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ProximoNivel()
    {
        Debug.Log("Foi para o proximo");
    }

    public void Pause()
    {

    }
    #endregion
}
