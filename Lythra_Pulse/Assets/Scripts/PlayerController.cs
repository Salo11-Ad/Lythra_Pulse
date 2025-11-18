using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 7f;
    private Rigidbody2D rb;

    private bool enSuelo;

    public Transform detectorSuelo;
    public float radioSuelo = 0.2f;
    public LayerMask pisoLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(mov * velocidad, rb.velocity.y);

        enSuelo = Physics2D.OverlapCircle(detectorSuelo.position, radioSuelo, pisoLayer);

        if (Input.GetButtonDown("Jump") && enSuelo)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.Morir();
        }
    }
}
