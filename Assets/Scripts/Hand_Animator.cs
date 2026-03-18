using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Hand_Animator : MonoBehaviour
{
    [SerializeField] private NearFarInteractor nearFarInteractor;
    [SerializeField] private SkinnedMeshRenderer handMesh;

    private void Awake()
    {
        // Подписываемся на захват
        nearFarInteractor.selectEntered.AddListener(OnGrab);
        // Подписываемся на отпускание (чтобы рука возвращалась)
        nearFarInteractor.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("Selected");
        if (handMesh != null) handMesh.enabled = false; // Исправлено на false
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        Debug.Log("Released");
        if (handMesh != null) handMesh.enabled = true; // Возвращаем руку
    }
}