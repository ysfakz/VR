using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sand : MonoBehaviour
{
    public GameObject chestPrefab;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        if (GameManager.Instance.hasShovel)
        {
            Vector3 spawnPos = transform.position;
            Quaternion spawnRot = transform.rotation;

            Destroy(gameObject); // Remove sand pile
            Instantiate(chestPrefab, spawnPos, spawnRot);
        }
    }
}
