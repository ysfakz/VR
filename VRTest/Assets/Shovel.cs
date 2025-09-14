using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Shovel : MonoBehaviour
{
    private XRSimpleInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);

    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        GameManager.Instance.hasShovel = true;   // Track shovel
        gameObject.SetActive(false);             // Hide shovel
        Debug.Log("Shovel Grabbed");
    }
}
