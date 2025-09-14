using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Sand : MonoBehaviour
{
    public GameObject chest;

    private XRSimpleInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        if (GameManager.Instance.hasShovel)
        {
            Vector3 spawnPos = transform.position;
            Quaternion spawnRot = transform.rotation;
            Debug.Log("Shovel Used");

            chest.transform.position = spawnPos;
            chest.transform.rotation = spawnRot;
            chest.SetActive(true);

            Destroy(gameObject); // Remove sand pile
            
        }
    }
}
