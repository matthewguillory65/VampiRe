using UnityEngine;
namespace Assets.Scripts
{
    public class TestStaticReferenceBehaviour : MonoBehaviour
    {
        public string left, right, sphere;
        private void Start()
        {
            left = HandsReference.LeftHand.name;
            right = HandsReference.RightHand.name;
            sphere = HandsReference.Sphere.name;
        }

        private void Update()
        {
            if(left.CompareTo(sphere) == 1 && right.CompareTo(sphere) == 1)
            {
                print("Works");
            }
            
        }
    }
}
