using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] Text textField;

    private int guess;
    private bool isGameEnded = false;

    void Start()
    {
        SetTheGuess();
    }

    void Update()
    {
        if (!isGameEnded)
        {
            IsAnyKeyPressed();
        }
    }

    private void IsAnyKeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess + 1;
            SetTheGuess();
            Debug.Log("No, it is higher than the number.");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            SetTheGuess();
            Debug.Log("No, it is lower than the number.");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            isGameEnded = true;
            textField.text = "Hehh, hehh I won!";
            Debug.Log("Hehh, hehh I won!");
        }
    }

    private void SetTheGuess()
    {
        guess = Random.Range(min, max + 1);
        textField.text = string.Format("Is it {0}?", guess);
    }

}
