using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shovel : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        GameManager.Instance.hasShovel = true;   // Track shovel
        gameObject.SetActive(false);             // Hide shovel
    }
}
