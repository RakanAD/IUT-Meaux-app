using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [Header("Sph�re 360� actuelle")]
    [Tooltip("On d�sactive la sph�re actuelle")]
    public GameObject currentSphere;

    [Header("Sph�re 360� suivante")]
    [Tooltip("On active la sph�re suivante")]
    public GameObject nextSphere;

    [Header("Sph�re Mini-carte actuelle")]
    [Tooltip("On active la sph�re actuelle")]
    public GameObject currentMap;

    [Header("Sph�re Mini-carte suivante")]
    [Tooltip("On active la sph�re suivante")]
    public GameObject nextMap;

    private void OnMouseDown()
    {
        HideAndShow();
    }
    public void HideAndShow()
    {
        currentMap.gameObject.SetActive(false);
        currentSphere.gameObject.SetActive(false);

        nextSphere.gameObject.SetActive(true);
        nextMap.gameObject.SetActive(true);

    }
}
    

