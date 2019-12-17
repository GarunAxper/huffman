using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter Text․");
            string input = Console.ReadLine();
            HuffmanTree huffmanTree = new HuffmanTree();
 
            huffmanTree.Build(input);
 
            BitArray encoded = huffmanTree.Encode(input);
 
            Console.Write("Encoded Text․ ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();
            Console.WriteLine();

            //string decoded = huffmanTree.Decode(encoded);
            foreach (var item in huffmanTree.Frequencies)
            {
                Console.Write(item.Key + "  " + item.Value + "  ");
                List<bool> key = huffmanTree.Root.Traverse(item.Key, new List<bool>());
                foreach (var bit in key)
                {
                    Console.Write((bit ? 1 : 0));
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
