using Sirenix.OdinInspector;

namespace Jozi.GameLibrary.BinaryTreeSource
{
    [System.Serializable]
    public class BinaryTree
    {
        [ShowInInspector]
        public IBinaryTreeNode MainBranch;

        public void SetNode(IBinaryTreeNode newBranch)
        {
            if (MainBranch == null)
            {
                MainBranch = newBranch;
                return;
            }
            SetNode(ref MainBranch, newBranch);
        }

        protected void SetNode(ref IBinaryTreeNode currentBranch, IBinaryTreeNode newBranch)
        {
            if (currentBranch.IsHigher(newBranch.Value))
            {
                if (currentBranch.HigherBranch == null)
                {
                    currentBranch.HigherBranch = newBranch;
                    return;
                }
                else
                {
                    SetNode(ref currentBranch.HigherBranch, newBranch);
                }
            }
            else
            {
                if (currentBranch.LowerBranch == null)
                {
                    currentBranch.LowerBranch = newBranch;
                    return;
                }
                else
                {
                    SetNode(ref currentBranch.LowerBranch, newBranch);
                }
            }
        }

        public int GetNode(int value)
        {
            return GetNode(MainBranch, value);
        }

        protected int GetNode(IBinaryTreeNode currentBranch, int value)
        {
            if (currentBranch.IsHigher(value))
            {
                if (currentBranch.HigherBranch == null)
                {
                    return currentBranch.Value;
                }
                else
                {
                    return GetNode(currentBranch.HigherBranch, value);
                }
            }
            else
            {
                if (currentBranch.LowerBranch == null)
                {
                    return currentBranch.Value;
                }
                else
                {
                    return GetNode(currentBranch.LowerBranch, value);
                }
            }
        }
    }
}