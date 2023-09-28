using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _btnText1;
    [SerializeField] private Text _btnText2;
    [SerializeField] private Text _btnText3;
    [SerializeField] private Text _btnText4;
    [SerializeField] private Text _btnText5;
    [SerializeField] private Text _btnText6;
    [SerializeField] private Text _btnText7;
    [SerializeField] private Text _btnText8;
    [SerializeField] private Text _btnText9;
    [SerializeField] private Text _btnResetGame;
    [SerializeField] private Text _btnNewGame;
    [SerializeField] private Text _msgFeedback;
    [SerializeField] private Text _txtPlayerX;
    [SerializeField] private Text _txtPlayerO;

    private bool checker;
    private int plusOne;

    private void Score()
    {
        if (_btnText1.text == "X" && _btnText2.text == "X" && _btnText3.text == "X")
        {
            _btnText1.color = Color.red;
            _btnText2.color = Color.red;
            _btnText3.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText1.text == "X" && _btnText4.text == "X" && _btnText7.text == "X")
        {
            _btnText1.color = Color.red;
            _btnText4.color = Color.red;
            _btnText7.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText2.text == "X" && _btnText5.text == "X" && _btnText8.text == "X")
        {
            _btnText2.color = Color.red;
            _btnText5.color = Color.red;
            _btnText8.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText3.text == "X" && _btnText6.text == "X" && _btnText9.text == "X")
        {
            _btnText3.color = Color.red;
            _btnText6.color = Color.red;
            _btnText9.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText4.text == "X" && _btnText5.text == "X" && _btnText6.text == "X")
        {
            _btnText4.color = Color.red;
            _btnText5.color = Color.red;
            _btnText6.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText7.text == "X" && _btnText8.text == "X" && _btnText9.text == "X")
        {
            _btnText7.color = Color.red;
            _btnText8.color = Color.red;
            _btnText9.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText1.text == "X" && _btnText5.text == "X" && _btnText9.text == "X")
        {
            _btnText1.color = Color.red;
            _btnText5.color = Color.red;
            _btnText9.color = Color.red;
            PlayerXWinner();
        }
        if (_btnText3.text == "X" && _btnText5.text == "X" && _btnText7.text == "X")
        {
            _btnText3.color = Color.red;
            _btnText5.color = Color.red;
            _btnText7.color = Color.red;
            PlayerXWinner();
        }

        //====================================================


        if (_btnText1.text == "O" && _btnText2.text == "O" && _btnText3.text == "O")
        {
            _btnText1.color = Color.red;
            _btnText2.color = Color.red;
            _btnText3.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText1.text == "O" && _btnText4.text == "O" && _btnText7.text == "O")
        {
            _btnText1.color = Color.red;
            _btnText4.color = Color.red;
            _btnText7.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText2.text == "O" && _btnText5.text == "O" && _btnText8.text == "O")
        {
            _btnText2.color = Color.red;
            _btnText5.color = Color.red;
            _btnText8.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText3.text == "O" && _btnText6.text == "O" && _btnText9.text == "O")
        {
            _btnText3.color = Color.red;
            _btnText6.color = Color.red;
            _btnText9.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText4.text == "O" && _btnText5.text == "O" && _btnText6.text == "O")
        {
            _btnText4.color = Color.red;
            _btnText5.color = Color.red;
            _btnText6.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText7.text == "O" && _btnText8.text == "O" && _btnText9.text == "O")
        {
            _btnText7.color = Color.red;
            _btnText8.color = Color.red;
            _btnText9.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText1.text == "O" && _btnText5.text == "O" && _btnText9.text == "O")
        {
            _btnText1.color = Color.red;
            _btnText5.color = Color.red;
            _btnText9.color = Color.red;
            PlayerOWinner();
        }
        if (_btnText3.text == "O" && _btnText5.text == "O" && _btnText7.text == "O")
        {
            _btnText3.color = Color.red;
            _btnText5.color = Color.red;
            _btnText7.color = Color.red;
            PlayerOWinner();
        }
    }
    private void PlayerXWinner()
    {
        _msgFeedback.text = "The Winner is Player X";
        plusOne = int.Parse(_txtPlayerX.text);
        _txtPlayerX.text = Convert.ToString(plusOne + 1);
    }
    private void PlayerOWinner()
    {
        _msgFeedback.text = "The Winner is Player O";
        plusOne = int.Parse(_txtPlayerO.text);
        _txtPlayerO.text = Convert.ToString(plusOne + 1);
    }

    public void BtnText1OnClick()
    {
        if (checker == false)
        {
            _btnText1.text = "X";
            checker = true;
        }
        else
        {
            _btnText1.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText2OnClick()
    {
        if (checker == false)
        {
            _btnText2.text = "X";
            checker = true;
        }
        else
        {
            _btnText2.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText3OnClick()
    {
        if (checker == false)
        {
            _btnText3.text = "X";
            checker = true;
        }
        else
        {
            _btnText3.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnTex4OnClick()
    {
        if (checker == false)
        {
            _btnText4.text = "X";
            checker = true;
        }
        else
        {
            _btnText4.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText5OnClick()
    {
        if (checker == false)
        {
            _btnText5.text = "X";
            checker = true;
        }
        else
        {
            _btnText5.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText6OnClick()
    {
        if (checker == false)
        {
            _btnText6.text = "X";
            checker = true;
        }
        else
        {
            _btnText6.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText7OnClick()
    {
        if (checker == false)
        {
            _btnText7.text = "X";
            checker = true;
        }
        else
        {
            _btnText7.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText8OnClick()
    {
        if (checker == false)
        {
            _btnText8.text = "X";
            checker = true;
        }
        else
        {
            _btnText8.text = "O";
            checker = false;
        }
        Score();
    }
    public void BtnText9OnClick()
    {
        if (checker == false)
        {
            _btnText9.text = "X";
            checker = true;
        }
        else
        {
            _btnText9.text = "O";
            checker = false;
        }
        Score();
    }

    public void ResetGame()
    {
        _btnText1.text = "";
        _btnText2.text = "";
        _btnText3.text = "";
        _btnText4.text = "";
        _btnText5.text = "";
        _btnText6.text = "";
        _btnText7.text = "";
        _btnText8.text = "";
        _btnText9.text = "";

        _btnText1.color = Color.black;
        _btnText2.color = Color.black;
        _btnText3.color = Color.black;
        _btnText4.color = Color.black;
        _btnText5.color = Color.black;
        _btnText6.color = Color.black;
        _btnText7.color = Color.black;
        _btnText8.color = Color.black;
        _btnText9.color = Color.black;

        _msgFeedback.text = "";

    }
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
