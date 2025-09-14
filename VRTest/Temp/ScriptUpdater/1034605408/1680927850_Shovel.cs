using UnityEngine.XR.Interaction.Toolkit;
private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;


public class Shovel : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);

    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        GameManager.Instance.hasShovel = true;   // Track shovel
        gameObject.SetActive(false);             // Hide shovel
    }
}
