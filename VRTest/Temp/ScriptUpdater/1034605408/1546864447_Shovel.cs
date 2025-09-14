using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shovel : MonoBehaviour
{
    // [SerializeField] private XRSimpleInteractable interactable;
    [SerializeField] private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable interactable;

    private void Awake()
    {
        // interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);

    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        GameManager.Instance.hasShovel = true;   // Track shovel
        gameObject.SetActive(false);             // Hide shovel
    }
}
