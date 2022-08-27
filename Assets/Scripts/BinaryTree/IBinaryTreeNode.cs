using Sirenix.OdinInspector;

namespace Jozi.GameLibrary.BinaryTreeSource
{
    [System.Serializable]
    public class IBinaryTreeNode
    {
        public int Value;

        [ShowInInspector] public IBinaryTreeNode LowerBranch;
        [ShowInInspector] public IBinaryTreeNode HigherBranch;

        public IBinaryTreeNode(int value)
        {
            Value = value;
        }

        public bool IsHigher(int value)
        {
            if (Value < value)
                return true;
            else
                return false;
        }
    }
}