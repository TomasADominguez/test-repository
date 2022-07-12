using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemplosLeantween : MonoBehaviour
{
    public Transform objetoAMirar;
    void Start()
    {
        //LeanTween.moveLocalY(gameObject, 3f, 1f).setLoopPingPong();

        var rotacionInicial = transform.rotation;

        transform.LookAt(objetoAMirar);
        var rotacionFinal = transform.rotation;
        transform.rotation = rotacionInicial;

        LeanTween.value(gameObject, (float value) =>
        {
            var rotacionYA = Quaternion.Slerp(rotacionInicial, rotacionFinal, value);
            transform.rotation = rotacionYA;
            // Vector3 posicionInicial = new Vector3(0f, 1f, -86f);
            // Vector3 posicionFinal = new Vector3(0f, 3f, -86f);

            // Vector3 escalaInicial = Vector3.one;
            // Vector3 escalaFinal = Vector3.one * 2f;

            // transform.position = Vector3.Lerp(posicionInicial, posicionFinal, value);
            // transform.localScale = Vector3.Lerp(escalaInicial, escalaFinal, value);
        }, 0f, 1f, 1f).setLoopPingPong();
    }
}


