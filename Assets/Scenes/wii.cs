using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wii : MonoBehaviour
{

    List<GameObject> list = new List<GameObject>();

    private void Start()
    {

        foreach (var item in FindObjectsOfType<a>())
        {
            list.Add(item.gameObject);
        }
        foreach (var item in list)
        {
            item.SetActive(false);
        }
        StartCoroutine(ACoroutine());

    }

    IEnumerator ACoroutine()
    {
        for (int i = 0; i < 50; i++)
        {
            for (int i2 = 0; i2 < list.Count; i2++)
            {
                list[i2].SetActive(false);
                list[i2].SetActive(true);
                yield return new WaitForSeconds(1);
                list[i2].SetActive(false);
            }

        }
    }

}
