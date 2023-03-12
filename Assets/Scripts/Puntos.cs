using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _PuntosGanados;

    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = GameManager.instance.puntuajeAcomulado;
        _PuntosGanados.text = "Puntos Ganados = " + puntos;

    }
}
