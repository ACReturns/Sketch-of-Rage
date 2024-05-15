using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] float walkSpeed = 5f;
	[SerializeField] float runSpeed = 10f;
	[SerializeField] float attackRadius = 3f;
	[SerializeField] int attackDamage = 2;
	[SerializeField] Vector2 knockBack = new Vector2(10f, 10f);
	[SerializeField] AudioClip attackSFX, gettingHitSFX;
	[SerializeField] Transform hurtBox;

	Rigidbody2D rigidbody2D;
	Animator animator;
	BoxCollider2D boxCollider;
	bool isInHitStun = false;
	bool run;

	// Start is called before the first frame update
	void Start()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		boxCollider = GetComponent<BoxCollider2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!isInHitStun)
		{
			Walk();
			PlayerAttack();

			if (boxCollider.IsTouchingLayers(LayerMask.GetMask("Enemy")))
			{
				PlayerHit();
			}
		}
	}

	public void PlayerHit()
	{
		rigidbody2D.velocity = knockBack * new Vector2(-transform.localScale.x, 1f);
		animator.SetTrigger("isHit");
		FindObjectOfType<GameSession>().ProcessPlayerDeath();
		isInHitStun = true;
		StartCoroutine(HitStun());

		//TODO Add a timer for hitstun so if the player gets away from getting attacked then it resets so they don't get knocked back 
	}

	private void PlayerAttack()
	{
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) 
		{
			animator.SetTrigger("isAttacking");
			Collider2D[] enemiesToHit = Physics2D.OverlapCircleAll(hurtBox.position, attackRadius, LayerMask.GetMask("Enemy"));

			foreach(Collider2D enemy in enemiesToHit) 
			{
				enemy.GetComponent<Enemy>().Dying();

				// TODO Check health value of enemy hit and deduct damage from the HP, is 0 then detroy them
				if (enemy.GetComponent<Enemy>().CheckEnemyType())
				{
					enemy.GetComponent<Enemy>().Dying();
				}
				else
				{
					enemy.GetComponent<Enemy>().EnemyHit(attackDamage);
				}
			}
		}
	}

	public IEnumerator Death()
	{
		animator.SetTrigger("isDying");
		boxCollider.enabled = false;
		rigidbody2D.bodyType = RigidbodyType2D.Static;
		yield return new WaitForSeconds(4f);
	}

	public void PlayerDeath()
	{
		FindObjectOfType<GameSession>().GameOver();
	}

	IEnumerator HitStun()
	{
		yield return new WaitForSeconds(.5f);
		isInHitStun = false;
	}

	IEnumerator Invulnerable()
	{
		Physics2D.IgnoreLayerCollision(7, 9, true);
		yield return new WaitForSeconds(3f);
		Physics2D.IgnoreLayerCollision(7, 9, false);
	}

	public void Walk()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");


		// Allows the player to move in both the X & Y Axis
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			run = true;
		}
		else if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			run = false;
			animator.SetBool("isRunning", false);
			Vector2 playerVelocity = new Vector2(movement.x * walkSpeed, movement.y);
			rigidbody2D.velocity = playerVelocity;
			ChangingToWalkingState();
		}

		if (run)
		{
			Vector2 playerVelocity = new Vector2(moveHorizontal * runSpeed, movement.y);
			rigidbody2D.velocity = playerVelocity;
			ChangingToRunningState();
		}
		else
		{
			Vector2 playerVelocity = new Vector2(moveHorizontal * walkSpeed, movement.y);
			rigidbody2D.velocity = playerVelocity;
			ChangingToWalkingState();
		}

		FlipSprite();
	}

	private void FlipSprite()
	{
		bool runningHorizontally = Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon;

		if (runningHorizontally)
		{
			transform.localScale = new Vector2(Mathf.Sign(rigidbody2D.velocity.x), 1f);
		}
	}

	private void ChangingToRunningState()
	{
		bool runningHorizontally = Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon || Mathf.Abs(rigidbody2D.velocity.y) > Mathf.Epsilon;
		animator.SetBool("isRunning", runningHorizontally);
	}

	private void ChangingToWalkingState()
	{
		bool walkingHorizontally = Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Epsilon || Mathf.Abs(rigidbody2D.velocity.y) > Mathf.Epsilon;
		animator.SetBool("isWalking", walkingHorizontally); 
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(hurtBox.position, attackRadius);
	}
}