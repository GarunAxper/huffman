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
            Console.WriteLine("Մուտքագրեք տեքստը․");
            string input = Console.ReadLine();
            HuffmanTree huffmanTree = new HuffmanTree();
 
            huffmanTree.Build(input);
 
            BitArray encoded = huffmanTree.Encode(input);
 
            Console.Write("Գաղտնագրված տեքստ․ ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();
 
            string decoded = huffmanTree.Decode(encoded);
 
            Console.WriteLine("Վերծանված տեքստ․ " + decoded);
 
            Console.ReadLine();
        }
    }
}
