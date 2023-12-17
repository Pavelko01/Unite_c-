[SerializeField] private int force = 2;

private void OnCollisionEnter(Collision collision)
{
   if (collision.gameObject.CompareTag("Player"))
   {
        collision.rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        
   }
}