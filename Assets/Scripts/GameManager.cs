using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    public int puntuajeAcomulado;
    private int puntuajeParaGanar = 5;
    [SerializeField] private GameObject[] _Paneles;
    [SerializeField] private GameObject Puntos, MenuPrincipal;
    [SerializeField] private Image[] _Images;
    [SerializeField] private GameObject OptionsMenu;
    [SerializeField] private GameObject Win;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    private void LateUpdate()
    {
        _textMeshProUGUI.text = "Puntos 5 de " + puntuajeAcomulado.ToString();
    }
    public void SumPoints(int imageSelect)
    {
        puntuajeAcomulado++;

        if (imageSelect == 1)
        {
            StartCoroutine("OneMoment");
            QuitQuestionOfTheArray(1);
            VerificarWin();

        }else if (imageSelect == 0 )
        {
            QuitQuestionOfTheArray(0);
            VerificarWin();
        } else if (imageSelect == 2)
        {
            StartCoroutine("OneMoment");
            QuitQuestionOfTheArray(2);
            VerificarWin();
        } else if (imageSelect == 3)
        {
            StartCoroutine("OneMoment");
            QuitQuestionOfTheArray(3);
            VerificarWin();
        } else if (imageSelect == 4)
        {
            StartCoroutine("OneMoment");
            QuitQuestionOfTheArray(4);
            VerificarWin();
        }
        
        StartCoroutine("NextQuestion");
    
    }

    public void VerificarWin()
    {
        while (puntuajeAcomulado == puntuajeParaGanar)
        {
            Puntos.SetActive(false);
            Win.SetActive(true);
            break;
        }
    }

    IEnumerator OneMoment()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        
    }
    
    public void ActivateOpctionMenu()
    {
        OptionsMenu.SetActive(true);
    }
    public void Return()
    {
        OptionsMenu.SetActive(false);
    }
    public void LoadScene(int scena)
    {
        SceneManager.LoadScene(scena);
    }
    IEnumerator NextQuestion()
    {
        float time = 3f;
        yield return new WaitForSeconds(time);
       ActivateQuestionRandom();
    }
    
    public void PrenderPuntuaje()
    {
        Puntos.SetActive(true);
        MenuPrincipal.SetActive(false);
        ActivateQuestionRandom();
    }
    
    /// <summary>
    /// Busca Una Pregunta Que No Haya Sido Destruida Para Mostrarla
    /// </summary>
    public void ActivateQuestionRandom()
    {
        int index = Random.Range(0, _Paneles.Length);
        if (_Paneles[index].gameObject != null)
        {
            _Paneles[index].SetActive(true);
        }
        else
        { 
            for (int i = 0; i < _Paneles.Length; i++)
            {
                if (_Paneles[i].gameObject != null)
                {
                    _Paneles[i].SetActive(true);
                    break;
                }
            }
        }

    }

    public void QuitQuestionOfTheArray(int index)
    {
        Destroy(_Paneles[index].gameObject);
    }

    public void Help1()
    {
        if (_Paneles[0].gameObject == enabled)
        {
            for (int i = 0; i < _Images.Length; i++)
            {
                _Images[i].color = Color.green;
            }
            StartCoroutine("ResetColor");
        }
    }
    
    IEnumerator ResetColor()
    {
        float time = 1f;
        yield return new WaitForSeconds(time);
        for (int i = 0; i < _Images.Length; i++)
        {
            _Images[i].color = new Color(255, 255, 255, .5f);
        }
    }
}
