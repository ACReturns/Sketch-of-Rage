using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickup : MonoBehaviour
{
	[SerializeField] AudioClip applePickupSFX;
	[SerializeField] int appleValue = 2;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		AudioSource.PlayClipAtPoint(applePickupSFX, Camera.main.transform.position);
		FindObjectOfType<GameSession>().AddToHealth(appleValue);
		Destroy(gameObject);
	}
}
