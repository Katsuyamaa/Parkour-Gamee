using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    [Header("Target")]
    public KeyCode teleportKey = KeyCode.R; 
    public Transform teleportTarget; // I��nlan�lacak hedef obje

    void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            TeleportObjects();
        }
    }

    void TeleportObjects()
    {
        // "player" ve "camera holder" adl� objeleri bulur
        GameObject playerObject = GameObject.Find("Player");
        GameObject cameraHolderObject = GameObject.Find("CameraHolder");

        // E�er objeler bulunamazsa uyar� verir ve i�lemi sonland�r�r
        if (playerObject == null || cameraHolderObject == null || teleportTarget == null)
        {
            Debug.LogError("Objeler Bulunamad�. �simleri kontrol et");
            return;
        }

        // "player" ve "camera holder" objelerini "teleportTarget" objesinin pozisyonuna ���nlar
        playerObject.transform.position = teleportTarget.position;
        cameraHolderObject.transform.position = teleportTarget.position;
    }
}
