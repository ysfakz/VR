using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool hasShovel = false;
    public GameObject shovelImage;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        shovelImage.SetActive(false);
    }
}
