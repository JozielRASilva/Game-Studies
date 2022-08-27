using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jozi.GameLibrary.BinaryTreeSource
{
    public class BinaryTreeTester : MonoBehaviour
    {
        public BinaryTree binaryTree;
        public int value = 2;
        public List<int> test = new List<int>();

        private IEnumerator Start()
        {
            binaryTree = new BinaryTree();
            test = new List<int>();

            for (int i = 1; i < 10000; i++)
            {
                IBinaryTreeNode node = new IBinaryTreeNode(Random.Range(0, 10000));
                binaryTree.SetNode(node);
                test.Add(node.Value);
                yield return null;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                float time = Time.realtimeSinceStartup;
                int result = binaryTree.GetNode(value);
                Debug.Log($"Binary Tree Passed {Time.realtimeSinceStartup - time}: {result}");

                time = Time.realtimeSinceStartup;
                for (int i = 0; i < test.Count; i++)
                {
                    if (test[i] == value)
                    {
                        result = test[i];
                        break;
                    }
                }
                Debug.Log($"For on list Passed {Time.realtimeSinceStartup - time}: {result}");
            }
        }
    }
}