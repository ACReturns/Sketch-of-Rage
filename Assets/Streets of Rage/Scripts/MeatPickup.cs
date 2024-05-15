using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatPickup : MonoBehaviour
{
	[SerializeField] AudioClip meatPickupSFX;
	[SerializeField] int meatValue = 3;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		AudioSource.PlayClipAtPoint(meatPickupSFX, Camera.main.transform.position);
		FindObjectOfType<GameSession>().AddToHealth(meatValue);
		Destroy(gameObject);
	}
}
