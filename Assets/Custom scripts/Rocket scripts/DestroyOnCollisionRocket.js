var explosionPrefab : Transform;

function OnCollisionEnter(collision : Collision) {

	if(collision.gameObject.tag == "Rocket") {

		var contact = collision.contacts[0];
		var rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		var pos = contact.point;
		Instantiate(explosionPrefab, pos, rot);

		Destroy (gameObject);
	}
}