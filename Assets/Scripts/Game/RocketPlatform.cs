using UnityEngine;

namespace SmallGame
{
    // Add this alongside a Platform component to make it apply a horizontal
    // kick (and a stronger vertical bounce) when the player lands on it.
    public class RocketPlatform : MonoBehaviour
    {
        public float horizontalKick = 12f;
        public float bounceMultiplier = 1.25f;
        // +1 = right, -1 = left. Set at spawn time.
        public int direction = 1;

        public SpriteRenderer arrowVisual; // optional child arrow

        void Start() { ApplyVisualDirection(); }

        public void SetDirection(int dir)
        {
            direction = dir >= 0 ? 1 : -1;
            ApplyVisualDirection();
        }

        void ApplyVisualDirection()
        {
            if (arrowVisual != null)
            {
                var s = arrowVisual.transform.localScale;
                s.x = Mathf.Abs(s.x) * direction;
                arrowVisual.transform.localScale = s;
            }
        }
    }
}
