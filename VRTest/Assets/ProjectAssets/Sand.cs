using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Sand : MonoBehaviour
{
    public GameObject chest;
    public Canvas shovelCanvas;
    private XRSimpleInteractable interactable;
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
        shovelCanvas.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        if (GameManager.Instance.hasShovel)
        {
            Vector3 spawnPos = transform.position;
            Quaternion spawnRot = transform.rotation;
            Debug.Log("Shovel Used");
            GameManager.Instance.shovelImage.SetActive(false);

            chest.transform.position = spawnPos;
            chest.transform.rotation = spawnRot;
            chest.SetActive(true);

            Destroy(gameObject);
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
            StartCoroutine(ShowShovelCanvas());
        }
    }

    private IEnumerator ShowShovelCanvas()
    {
        shovelCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        shovelCanvas.gameObject.SetActive(false);
    }
}
