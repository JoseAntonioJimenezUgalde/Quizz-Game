using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateColor : MonoBehaviour
{
    [SerializeField] public GameObject Red;
    [SerializeField] public GameObject Green;
    [SerializeField] public GameObject ImageCorrectOfHelp;

    public void ActivarColor()
    {
        Red.SetActive(true);
        StartCoroutine("DeactivateColor");
    }
    IEnumerator DeactivateColor()
    {
        float time = 0.5f;
        yield return new WaitForSeconds(1);
        Red.SetActive(false);
    }
    public void NextCuestion0()
    {
        ActivateColorGreen();
        StartCoroutine("Time0");
    }
    IEnumerator Time0()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        GameManager.instance.SumPoints(0);
    }
    public void NextCuiestion()
    {
        ActivarColor();
        StartCoroutine("Time");
        
    }
    public void NextCuestion2()
    {
        ActivateColorGreen();
        StartCoroutine("Time2");
    }

    public void NextCuestion3()
    {
        ActivateColorGreen();
        StartCoroutine("Time3");
    }
    IEnumerator Time3()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        GameManager.instance.SumPoints(3);
    }

    public void NextCuestion4()
    {
        ActivateColorGreen();
        StartCoroutine("Time4");
    }
    IEnumerator Time4()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        GameManager.instance.SumPoints(4);
    }

    public void ActivateColorGreen()
    {
        Green.SetActive(true);
        StartCoroutine("DeactivateColorGreen");
    }
    IEnumerator DeactivateColorGreen()
    {
        float time = 0.5f;
        yield return new WaitForSeconds(1);
        Green.SetActive(false);
    }

    IEnumerator Time()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        GameManager.instance.SumPoints(1);
    }
    
    IEnumerator Time2()
    {
        float time = 1;
        yield return new WaitForSeconds(time);
        GameManager.instance.SumPoints(2);
    }
    
    public void Help()
    {
        ImageCorrectOfHelp.SetActive(true);
        StartCoroutine("ResetColor");
    }
    IEnumerator ResetColor()
    {
        float time = 1f;
        yield return new WaitForSeconds(time);
        ImageCorrectOfHelp.SetActive(false);
    }

}
