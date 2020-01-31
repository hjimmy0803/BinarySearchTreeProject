using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTProject
{
    class BinarySearchTree
    {
        //--------------------------------------------------------Member Variable----------------------------------------------------------------------------------------
        public Node root;

        //--------------------------------------------------------Memmber Method----------------------------------------------------------------------------------
        public void Add(int data) 
        {
            Node current;

            if (root == null)  
            {
                root = new Node(data);
                return;
            
            }
            current = root;

            while (true) 
            {
                if(data >= current.data) // going right
                {
                     if (current.rightChild == null) 
                     {

                        current.rightChild = new Node(data);
                        break;
                     }
                     else
                     {
                         current = current.rightChild;
                     }
                }
               else if(data <= current.data) // going left
                {
                    if (current.leftChild == null) 
                    {
                        current.leftChild = new Node(data);
                        break;
                    
                    }
                    else
                    {
                        current = current.leftChild;
                    }

                }
               
            }
           
        }
        public bool Find(int data) 
        {
            

            if (root == null)
            {
                return false;

            }
            Node current = root;

            while (true)
            {
                if (data == current.data) // going right
                {
                    if (current.rightChild == null)
                    {

                        current.rightChild = new Node(data);
                        return true;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else if (data == current.data) // going left
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new Node(data);
                        return true;

                    }
                    else
                    {
                        current = current.leftChild;
                    }

                }

            }
            
             
        
        }
        
      
    }

  
}
