using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasciNetPro
{
    public class EncoderUse
    {
        public void EncoderUseExample()
        {
            // Encoder
            string test = "ABCDE1234测试";
            Console.WriteLine("The test of string is {0}", test);
            Encoding encoding = Encoding.UTF8;
            char[] source = test.ToCharArray();
            int strLength = test.Length;
            int len = encoding.GetEncoder().GetByteCount(source, 0, strLength, false);
            byte[] result = new byte[len];
            encoding.GetEncoder().GetBytes(source,0,strLength,result,0,false);
            Console.WriteLine("After Encoder,the byte of test is output below.");
            foreach(byte b in result)
            {
                Console.WriteLine("{0:X}-",b);
            }
            Console.WriteLine();

            //Decoder
            Console.WriteLine("After Decoder,the string is ");
            int deslen = encoding.GetDecoder().GetCharCount(result,0,result.Length);

            char[] des = new char[deslen];
            encoding.GetDecoder().GetChars(result,0,result.Length,des,0);
            foreach(char c in des)
            {
                Console.WriteLine("{0}",c);
            }
            Console.WriteLine("\n");
            //Console.ReadLine();
        }
    }
}
