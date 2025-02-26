using UnityEngine;
using UnityEngine.UI;

public class DinoImageFlip : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Image _dinoImage;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _dinoImage = GetComponent<Image>();
    }
    private void Update()
    {
        if (_rigidbody2D.velocity.x > 0)
        {
            _dinoImage.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (_rigidbody2D.velocity.x < 0)
        {
            _dinoImage.rectTransform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
