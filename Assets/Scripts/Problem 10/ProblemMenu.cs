using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProblemMenu : MonoBehaviour
{
    public Button Problem1Button, Problem2Button, Problem3Button, Problem4Button, Problem5Button,
                  Problem6Button, Problem7Button, Problem8Button, Problem9Button;

    // Start is called before the first frame update
    void Start()
    {
        Problem1Button.onClick.AddListener(Problem1);
        Problem2Button.onClick.AddListener(Problem2);
        Problem3Button.onClick.AddListener(Problem3);
        Problem4Button.onClick.AddListener(Problem4);
        Problem5Button.onClick.AddListener(Problem5);
        Problem6Button.onClick.AddListener(Problem6);
        Problem7Button.onClick.AddListener(Problem7);
        Problem8Button.onClick.AddListener(Problem8);
        Problem9Button.onClick.AddListener(Problem9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Problem1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Problem2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    private void Problem3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    private void Problem4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    private void Problem5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    private void Problem6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    private void Problem7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    private void Problem8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    private void Problem9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
}
