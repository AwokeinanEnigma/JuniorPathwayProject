using UnityEngine;

namespace DefaultNamespace
{
    // demonstrates inheritance
    public class GenericBox : Box
    {
        // demonstrates polymorphism
        public override void OnPickedUp()
        {
            Debug.Log("Hello, world!");
        }

        public override void OnDropped()
        {
            Debug.Log("Goodbye, world!");
        }

        public override void WhilePickedup()
        {
            base.WhilePickedup();
            Debug.Log("I'm being held!");
        }
    }
}