using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Rigidbody2D leftArm;
	[SerializeField] private Rigidbody2D rightArm;

	[SerializeField] private float power;

	private bool IsPressKeyLeft = false;
	private bool IsPressKeyRight = false;

	public void InputLeft()
	{
		IsPressKeyLeft = true;
		Debug.Log("In");
	}
	public void OutputLeft()
	{
		IsPressKeyLeft = false;
		Debug.Log("Out");
	}

	public void InputRight()
	{
		IsPressKeyRight = true;
	}
	public void OutputRight()
	{
		IsPressKeyRight = false;
	}

	private void Update()
	{
		if (IsPressKeyLeft)
			Hit(leftArm);

		if (IsPressKeyRight)
			Hit(rightArm);
	}

	private void Hit(Rigidbody2D current)
	{
		current.AddForce(Vector2.up * power);
	}
}