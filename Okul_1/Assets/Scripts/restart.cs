using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    [Header("Target")]
    public KeyCode teleportKey = KeyCode.R; 
    public Transform teleportTarget; // Iþýnlanýlacak hedef obje

    void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            TeleportObjects();
        }
    }

    void TeleportObjects()
    {
        // "player" ve "camera holder" adlý objeleri bulur
        GameObject playerObject = GameObject.Find("Player");
        GameObject cameraHolderObject = GameObject.Find("CameraHolder");

        // Eðer objeler bulunamazsa uyarý verir ve iþlemi sonlandýrýr
        if (playerObject == null || cameraHolderObject == null || teleportTarget == null)
        {
            Debug.LogError("Objeler Bulunamadý. Ýsimleri kontrol et");
            return;
        }

        // "player" ve "camera holder" objelerini "teleportTarget" objesinin pozisyonuna ýþýnlar
        playerObject.transform.position = teleportTarget.position;
        cameraHolderObject.transform.position = teleportTarget.position;
    }
}
